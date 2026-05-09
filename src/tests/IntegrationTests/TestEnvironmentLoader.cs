using System.Runtime.CompilerServices;

namespace AssemblyAI.IntegrationTests;

internal static class TestEnvironmentLoader
{
    [ModuleInitializer]
    internal static void Load()
    {
        DotEnv.Load(Path.Combine(AppContext.BaseDirectory, ".env"));
    }

    private static class DotEnv
    {
        internal static void Load(string path)
        {
            if (!File.Exists(path))
            {
                return;
            }

            foreach (var rawLine in File.ReadAllLines(path))
            {
                var line = rawLine.Trim();
                if (line.Length == 0 || line.StartsWith('#'))
                {
                    continue;
                }

                var separatorIndex = line.IndexOf('=');
                if (separatorIndex <= 0)
                {
                    continue;
                }

                var key = line[..separatorIndex].Trim();
                var value = line[(separatorIndex + 1)..].Trim();

                if (value.Length >= 2 && value[0] == '"' && value[^1] == '"')
                {
                    value = value[1..^1];
                }

                if (key.Length == 0)
                {
                    continue;
                }

                if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable(key)))
                {
                    continue;
                }

                Environment.SetEnvironmentVariable(key, value);
            }
        }
    }
}
