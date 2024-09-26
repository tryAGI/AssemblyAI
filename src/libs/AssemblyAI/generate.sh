dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/AssemblyAI/assemblyai-api-spec/main/openapi.yml
sudo npm i -g @apiture/openapi-down-convert
openapi-down-convert --input openapi.yaml --output openapi.yaml
dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
if [ $? -ne 0 ]; then
 echo "Failed, exiting..."
 exit 1
fi
autosdk generate openapi.yaml \
  --namespace AssemblyAI \
  --clientClassName AssemblyAIClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations