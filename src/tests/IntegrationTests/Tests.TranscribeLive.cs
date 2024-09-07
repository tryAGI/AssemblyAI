using System.Diagnostics;

namespace AssemblyAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task TranscribeLive()
    {
        using var client = GetAuthenticatedApi();
        
        // - You need to have `sox` installed on your system. If not, run:
        //   macOS: brew install sox (macOS)
        //   Linux: sudo apt-get install sox libsox-fmt-all
        //   Windows: manually download and install sox, and add sox to your PATH environment variable.
        //            https://sourceforge.net/projects/sox/

        // Set up the cancellation token, so we can stop the program with Ctrl+C
        var cts = new CancellationTokenSource();
        var ct = cts.Token;
        Console.CancelKeyPress += (sender, e) => cts.Cancel();

        // Set up the realtime transcriber
        // await using var transcriber = new RealtimeTranscriber(new RealtimeTranscriberOptions
        // {
        //     SampleRate = 16_000
        // });
        //
        // transcriber.PartialTranscriptReceived.Subscribe(transcript =>
        // {
        //     if (transcript.Text == "") return;
        //     Console.WriteLine($"Partial transcript: {transcript.Text}");
        // });
        // transcriber.FinalTranscriptReceived.Subscribe(transcript =>
        // {
        //     Console.WriteLine($"Final transcript: {transcript.Text}");
        // });

        //await transcriber.ConnectAsync();

        var soxArguments = string.Join(' ', [
            // --default-device doesn't work on Windows
            OperatingSystem.IsWindows() ? "-t waveaudio default" : "--default-device",
            "--no-show-progress",
            "--rate 16000",
            "--channels 1",
            "--encoding signed-integer",
            "--bits 16",
            "--type wav",
            "-" // pipe
        ]);
        Console.WriteLine($"sox {soxArguments}");
        using var soxProcess = new Process();
        soxProcess.StartInfo = new ProcessStartInfo
        {
            FileName = "sox",
            Arguments = soxArguments,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        soxProcess.Start();
        soxProcess.BeginErrorReadLine();
        var soxOutputStream = soxProcess.StandardOutput.BaseStream;
        var buffer = new Memory<byte>(new byte[4096]);
        while (await soxOutputStream.ReadAsync(buffer, ct) > 0)
        {
            if (ct.IsCancellationRequested) break;
            //await transcriber.SendAudioAsync(buffer);
        }

        soxProcess.Kill();
        //await transcriber.CloseAsync();
    }
}
