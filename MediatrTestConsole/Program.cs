using System.Threading;
using System.Threading.Tasks;
using Autofac;

namespace MediatrTestConsole
{
    internal static class Program
    {
        public static async Task Main(string[] args)
        {
            var container = ContainerConfig.Configure();
            var clt = new CancellationToken();
            var tickBackgroundService = container.Resolve<TickBackgroundService>();
            await tickBackgroundService.ExecuteAsync(clt);
        }
    }
}