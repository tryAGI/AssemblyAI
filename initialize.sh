dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  AssemblyAI \
  AssemblyAiApi \
  https://raw.githubusercontent.com/AssemblyAI/assemblyai-api-spec/main/openapi.yml \
  tryAGI \
  --output .