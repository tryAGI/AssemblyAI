#!/usr/bin/env bash
set -euo pipefail
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://raw.githubusercontent.com/AssemblyAI/assemblyai-api-spec/main/openapi.yml
autosdk generate openapi.yaml \
  --namespace AssemblyAI \
  --clientClassName AssemblyAIClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --ignore-openapi-errors

autosdk generate asyncapi.json \
  --namespace AssemblyAI.Realtime \
  --websocket-class-name AssemblyAIRealtimeClient \
  --json-serializer-context RealtimeSourceGenerationContext \
  --targetFramework net8.0 \
  --output Generated
