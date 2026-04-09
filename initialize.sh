dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  AssemblyAI \
  AssemblyAiApi \
  https://www.assemblyai.com/docs/api-reference/openapi.json \
  tryAGI \
  --output .
