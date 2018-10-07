using System;
using System.Runtime.InteropServices;
using Docker.DotNet;

namespace Andoromeda.TestFx.Eos
{
    public class EosTestContext : IDisposable
    {
        private readonly DockerClient client;
        EosTestContext()
        {
            string uri;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                uri = "//./pipe/docker_engine";
            }
            else
            {
                uri = "unix:/var/run/docker.sock";
            }
            var config = new DockerClientConfiguration(new Uri(uri));
            client = config.CreateClient();
        }

        public void Dispose()
        {
        }
    }
}
