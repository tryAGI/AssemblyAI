dotnet tool install --global openapigenerator.cli --prerelease

oag init \
  AssemblyAI \
  AssemblyAiApi \
  https://raw.githubusercontent.com/AssemblyAI/assemblyai-api-spec/main/openapi.yml \
  tryAGI \
  --output .