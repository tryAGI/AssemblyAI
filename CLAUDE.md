# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [AssemblyAI](https://www.assemblyai.com/) speech-to-text and audio intelligence API, auto-generated from the official AssemblyAI OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as NuGet package `tryAGI.AssemblyAI`. Note: AssemblyAI has an [official .NET SDK](https://github.com/AssemblyAI/assemblyai-csharp-sdk); this community SDK aims to match or exceed its capabilities.

## Build Commands

```bash
# Build the solution
dotnet build AssemblyAI.sln

# Build for release (also produces NuGet package)
dotnet build AssemblyAI.sln -c Release

# Run integration tests (requires ASSEMBLYAI_API_KEY env var)
dotnet test src/tests/IntegrationTests/AssemblyAI.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/AssemblyAI && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code in `src/libs/AssemblyAI/Generated/` is **entirely auto-generated** -- do not manually edit files there.

1. `src/libs/AssemblyAI/openapi.yaml` -- the AssemblyAI OpenAPI spec (fetched from the official `assemblyai-api-spec` repo)
2. `src/libs/AssemblyAI/generate.sh` -- orchestrates: download spec, run AutoSDK CLI with `--ignore-openapi-errors`, output to `Generated/`
3. Note: the FixOpenApiSpec step is commented out in generate.sh for this SDK
4. CI auto-updates the spec and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/AssemblyAI/` | Main SDK library (`AssemblyAIClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real AssemblyAI API |
| `src/helpers/FixOpenApiSpec/` | OpenAPI spec fixer tool (currently unused) |
| `src/helpers/GenerateDocs/` | Documentation generator from integration tests |
| `src/helpers/TrimmingHelper/` | NativeAOT/trimming compatibility validator |

### Hand-Written Extensions

This SDK includes hand-written code for convenience wrappers and AI abstractions:

| File/Directory | Purpose |
|----------------|---------|
| `Conversions/TranscriptParams.cs` | Helper for creating transcript parameters from URLs |
| `Conversions/TranscriptParamsVariant1.cs` | Variant transcript parameter helpers |
| `Conversions/LemurTaskParams.cs` | Lemur task parameter helpers |
| `Conversions/LemurTaskParamsVariant1.cs` | Variant Lemur task parameter helpers |
| `Extensions/Transcript.cs` | Transcript convenience methods (e.g., `EnsureStatusCompleted()`) |
| `Extensions/AssemblyAIClient.SpeechToTextClient.cs` | Microsoft.Extensions.AI speech-to-text integration |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + FluentAssertions
- **Dependencies:** Microsoft.Extensions.AI.Abstractions

### Key Conventions

- The client class is named `AssemblyAIClient`
- The namespace is `AssemblyAI`
- Use `TranscriptParams.FromUrl()` for creating transcript requests
- Transcript results expose `EnsureStatusCompleted()` for polling validation

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
