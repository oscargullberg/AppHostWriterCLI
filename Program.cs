using Microsoft.NET.HostModel.AppHost;

namespace AppHostWriter.CLI
{
    public class Program
    {
        static Task<int> Main(string[] args)
        {
            var appHostPath = args[0];
            var outputPath = args[1];
            var appDllPath = args[2];
            var isGui = false;
            if (args.Length > 3)
            {
                bool.TryParse(args[3], out isGui);
            }
            var assemblyWithResourcesPath = args.Length > 4 ? args[4] : appDllPath;

            HostWriter.CreateAppHost(appHostPath, outputPath, appDllPath, isGui, assemblyWithResourcesPath);

            return Task.FromResult(0);
        }
    }
}