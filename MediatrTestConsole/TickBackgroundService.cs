using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MediatrTestConsole
{
    public class TickBackgroundService
    {
        private readonly IMediator _mediatR;

        public TickBackgroundService(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        public async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                //Console.WriteLine(DateTime.Now);
                await _mediatR.Publish(new TickerForEverySecond(DateTime.Now), stoppingToken);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}