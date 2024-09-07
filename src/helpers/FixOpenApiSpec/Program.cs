using Microsoft.OpenApi;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var text = await File.ReadAllTextAsync(path);

text = text
        .Replace("openapi: 3.1.0", "openapi: 3.0.1")
        .Replace("          type: [boolean, \"null\"]", @"          type: boolean
          nullable: true")
        .Replace("          type: [number, \"null\"]",  @"          type: number
          nullable: true")
        .Replace("          type: [string, \"null\"]",  @"          type: string
          nullable: true")
        .Replace("          type: [integer, \"null\"]",  @"          type: integer
          nullable: true")
        .Replace("          type: [array, \"null\"]",  @"          type: array
          nullable: true")
    ;

var openApiDocument = new OpenApiStringReader().Read(text, out var diagnostics);

text = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(text, out diagnostics);

if (text.Contains(", \"null\""))
{
    throw new Exception("Failed to remove nullable from OpenAPI 3.1 spec.");
}

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, text);
return;