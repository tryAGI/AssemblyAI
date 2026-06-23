using AssemblyAI.Realtime;

namespace AssemblyAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void StreamingConnectOptions_BuildsUriWithDefaults()
    {
        var uri = new StreamingConnectOptions().BuildUri();

        uri.Scheme.Should().Be("wss");
        uri.Host.Should().Be("streaming.assemblyai.com");
        uri.AbsolutePath.Should().Be("/v3/ws");
        uri.Query.Should().Contain("sample_rate=16000");
        uri.Query.Should().Contain("speech_model=u3-rt-pro");
        uri.Query.Should().Contain("encoding=pcm_s16le");
        uri.Query.Should().Contain("format_turns=false");
        uri.Query.Should().NotContain("token=");
        uri.Query.Should().NotContain("api_key=");
    }

    [TestMethod]
    public void StreamingConnectOptions_UsesEuRegion()
    {
        var uri = new StreamingConnectOptions { Region = "eu" }.BuildUri();

        uri.Host.Should().Be("streaming.eu.assemblyai.com");
    }

    [TestMethod]
    public void StreamingConnectOptions_UsRegionIsCaseInsensitive()
    {
        var uri = new StreamingConnectOptions { Region = "EU" }.BuildUri();

        uri.Host.Should().Be("streaming.eu.assemblyai.com");
    }

    [TestMethod]
    public void StreamingConnectOptions_EncodesKeytermsAsJsonArray()
    {
        var uri = new StreamingConnectOptions
        {
            KeytermsPrompt = ["hello world", "AssemblyAI"],
        }.BuildUri();

        // AssemblyAI v3 expects a single keyterms_prompt parameter containing a URL-encoded JSON array.
        uri.Query.Should().Contain("keyterms_prompt=" + Uri.EscapeDataString("[\"hello world\",\"AssemblyAI\"]"));
    }

    [TestMethod]
    public void StreamingConnectOptions_OmitsKeytermsWhenEmpty()
    {
        var uri = new StreamingConnectOptions
        {
            KeytermsPrompt = [],
        }.BuildUri();

        uri.Query.Should().NotContain("keyterms_prompt");
    }

    [TestMethod]
    public void StreamingConnectOptions_SkipsEmptyEntriesInKeyterms()
    {
        var uri = new StreamingConnectOptions
        {
            KeytermsPrompt = ["", "ok"],
        }.BuildUri();

        uri.Query.Should().Contain("keyterms_prompt=" + Uri.EscapeDataString("[\"ok\"]"));
    }

    [TestMethod]
    public void StreamingConnectOptions_EscapesQuotesInKeyterms()
    {
        var uri = new StreamingConnectOptions
        {
            KeytermsPrompt = ["she said \"hi\""],
        }.BuildUri();

        uri.Query.Should().Contain("keyterms_prompt=" + Uri.EscapeDataString("[\"she said \\\"hi\\\"\"]"));
    }

    [TestMethod]
    public void StreamingConnectOptions_TokenIsAppendedAsQuery()
    {
        var uri = new StreamingConnectOptions { Token = "ephemeral" }.BuildUri();

        uri.Query.Should().Contain("token=ephemeral");
    }

    [TestMethod]
    public void StreamingConnectOptions_RoundTripsCustomEncoding()
    {
        var uri = new StreamingConnectOptions { Encoding = "pcm_mulaw" }.BuildUri();

        uri.Query.Should().Contain("encoding=pcm_mulaw");
    }

    [TestMethod]
    public void StreamingConnectOptions_FormatTurnsLowercased()
    {
        var uri = new StreamingConnectOptions { FormatTurns = true }.BuildUri();

        uri.Query.Should().Contain("format_turns=true");
        uri.Query.Should().NotContain("format_turns=True");
    }

    [TestMethod]
    public void StreamingConnectOptions_UrlEncodesToken()
    {
        var uri = new StreamingConnectOptions { Token = "k+y/=z" }.BuildUri();

        uri.Query.Should().Contain("token=k%2By%2F%3Dz");
    }

    [TestMethod]
    public void StreamingConnectOptions_CustomSampleRateIsRendered()
    {
        var uri = new StreamingConnectOptions { SampleRate = 8000 }.BuildUri();

        uri.Query.Should().Contain("sample_rate=8000");
    }

    [TestMethod]
    public void StreamingConnectOptions_RendersUniversal35ProRealtimeOptions()
    {
        var uri = new StreamingConnectOptions
        {
            AgentContext = "What is your email address?",
            LanguageCode = "en",
            VoiceFocus = "near-field",
            VoiceFocusThreshold = 0.75,
            SpeakerLabels = true,
            MaxSpeakers = 2,
            PreviousContextNTurns = 3,
            ContinuousPartials = true,
            IncludePartialTurns = true,
            InterruptionDelay = 250,
        }.BuildUri();

        uri.Query.Should().Contain("agent_context=What%20is%20your%20email%20address%3F");
        uri.Query.Should().Contain("language_code=en");
        uri.Query.Should().Contain("voice_focus=near-field");
        uri.Query.Should().Contain("voice_focus_threshold=0.75");
        uri.Query.Should().Contain("speaker_labels=true");
        uri.Query.Should().Contain("max_speakers=2");
        uri.Query.Should().Contain("previous_context_n_turns=3");
        uri.Query.Should().Contain("continuous_partials=true");
        uri.Query.Should().Contain("include_partial_turns=true");
        uri.Query.Should().Contain("interruption_delay=250");
    }
}
