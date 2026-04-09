#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://www.assemblyai.com/docs/api-reference/openapi.json (+ AsyncAPI)

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
tmp_openapi="$(mktemp)"
if curl --fail --silent --show-error -L -o "$tmp_openapi" https://www.assemblyai.com/docs/api-reference/openapi.json; then
  mv "$tmp_openapi" openapi.yaml
else
  echo "warning: failed to download AssemblyAI OpenAPI spec, using committed openapi.yaml" >&2
  rm -f "$tmp_openapi"
fi
autosdk generate openapi.yaml \
  --namespace AssemblyAI \
  --clientClassName AssemblyAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --ignore-openapi-errors

autosdk generate asyncapi.json \
  --namespace AssemblyAI.Realtime \
  --websocket-class-name AssemblyAIRealtimeClient \
  --json-serializer-context RealtimeSourceGenerationContext \
  --targetFramework net10.0 \
  --output Generated
