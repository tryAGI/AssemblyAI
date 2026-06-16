#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://www.assemblyai.com/docs/api-reference/openapi.json (+ AsyncAPI)

use_pinned_spec=false
for arg in "$@"; do
  case "$arg" in
    --pinned-spec)
      use_pinned_spec=true
      ;;
    *)
      echo "Unknown argument: $arg" >&2
      exit 1
      ;;
  esac
done
if [[ "${TRYAGI_PINNED_SPEC:-0}" == "1" ]]; then
  use_pinned_spec=true
fi
install_autosdk_cli
rm -rf Generated
if [[ "$use_pinned_spec" == false ]]; then
  tmp_openapi="$(mktemp)"
  if fetch_spec --fail --silent --show-error -L -o "$tmp_openapi" https://www.assemblyai.com/docs/api-reference/openapi.json; then
    mv "$tmp_openapi" openapi.yaml
  else
    echo "warning: failed to download AssemblyAI OpenAPI spec, using committed openapi.yaml" >&2
    rm -f "$tmp_openapi"
  fi
elif [[ ! -f openapi.yaml ]]; then
  echo "error: --pinned-spec requested but openapi.yaml does not exist." >&2
  exit 1
fi
autosdk generate openapi.yaml \
  --namespace AssemblyAI \
  --clientClassName AssemblyAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --generate-http-exception-hierarchy \
  --generate-retry-handler \
  --generate-pageable-helpers \
  --generate-multipart-upload-helpers \
  --ignore-openapi-errors

autosdk generate asyncapi.json \
  --namespace AssemblyAI.Realtime \
  --websocket-class-name AssemblyAIRealtimeClient \
  --json-serializer-context RealtimeSourceGenerationContext \
  --targetFramework net10.0 \
  --output Generated
