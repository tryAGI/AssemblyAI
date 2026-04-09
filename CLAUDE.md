# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [AssemblyAI](https://www.assemblyai.com/) speech-to-text and audio intelligence API, auto-generated from the official AssemblyAI OpenAPI + AsyncAPI specifications using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as NuGet package `tryAGI.AssemblyAI`. Note: AssemblyAI has an [official .NET SDK](https://github.com/AssemblyAI/assemblyai-csharp-sdk); this community SDK aims to match or exceed its capabilities.

## Build Commands

```bash
# Build the solution
dotnet build AssemblyAI.slnx

# Build for release (also produces NuGet package)
dotnet build AssemblyAI.slnx -c Release

# Run integration tests (requires ASSEMBLYAI_API_KEY env var)
dotnet test src/tests/IntegrationTests/AssemblyAI.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/AssemblyAI && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code in `src/libs/AssemblyAI/Generated/` is **entirely auto-generated** -- do not manually edit files there.

1. `src/libs/AssemblyAI/openapi.yaml` -- the AssemblyAI OpenAPI spec cache (downloaded from `https://www.assemblyai.com/docs/api-reference/openapi.json`)
2. `src/libs/AssemblyAI/asyncapi.json` -- AsyncAPI 3.0.0 spec for v3 real-time streaming WebSocket API
3. `src/libs/AssemblyAI/generate.sh` -- orchestrates: download spec, run AutoSDK CLI for OpenAPI + AsyncAPI, output to `Generated/`
4. CI auto-updates the spec and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/AssemblyAI/` | Main SDK library (`AssemblyAIClient` + `AssemblyAIRealtimeClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real AssemblyAI API |

### Documentation Generation

Tests in `src/tests/IntegrationTests/Examples` are the single source of truth for both test coverage and documentation:
- Each file has a JSDoc header (`order`, `title`, `slug`) consumed by `autosdk docs sync .`
- Comments prefixed with `////` become prose paragraphs in generated docs
- CI workflow (`.github/workflows/mkdocs.yml`) auto-generates `docs/examples/` and populates `EXAMPLES:START/END` markers in README.md, docs/index.md, and mkdocs.yml
- Config: `autosdk.docs.json` points to `src/tests/IntegrationTests/Examples`
### Hand-Written Extensions

This SDK includes hand-written code for convenience wrappers and AI abstractions:

| File/Directory | Purpose |
|----------------|---------|
| `Conversions/TranscriptParams.cs` | Helper for creating transcript parameters from URLs |
| `Conversions/TranscriptParamsVariant1.cs` | Variant transcript parameter helpers |
| `Extensions/Transcript.cs` | Transcript convenience methods (e.g., `EnsureStatusCompleted()`) |
| `Extensions/AssemblyAIClient.SpeechToTextClient.cs` | Microsoft.Extensions.AI speech-to-text integration |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + AwesomeAssertions
- **Dependencies:** Microsoft.Extensions.AI.Abstractions

### Real-Time Streaming WebSocket API

The `AssemblyAIRealtimeClient` (in namespace `AssemblyAI.Realtime`) is auto-generated from `asyncapi.json` and provides:
- Typed send methods: `SendUpdateConfigurationAsync()`, `SendForceEndpointAsync()`, `SendSessionTerminationAsync()`
- `ReceiveUpdatesAsync()` returning a discriminated `ServerEvent` union (`IsBegin`, `IsTurn`, `IsTermination`)
- Binary audio sent via base `SendAsync(bytes)` method
- Connects to `streaming.assemblyai.com/v3/ws`

### Key Conventions

- The client class is named `AssemblyAIClient` (REST) / `AssemblyAIRealtimeClient` (WebSocket)
- The namespace is `AssemblyAI` (REST) / `AssemblyAI.Realtime` (WebSocket)
- Use `TranscriptParams.FromUrl()` for creating transcript requests
- Transcript results expose `EnsureStatusCompleted()` for polling validation

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
