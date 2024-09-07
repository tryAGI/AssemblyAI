dotnet tool install --global openapigenerator.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/AssemblyAI/assemblyai-api-spec/main/openapi.yml
sudo npm install -g openapi-down-converter
openapi-down-convert --input openapi.yaml --output openapi.yaml
dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
if [ $? -ne 0 ]; then
 echo "Failed, exiting..."
 exit 1
fi
oag generate openapi.yaml \
  --namespace AssemblyAI \
  --clientClassName AssemblyAIClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations