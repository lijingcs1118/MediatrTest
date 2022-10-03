using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MediatrTestConsole
{
    public class EverySecondHandler:INotificationHandler<TickerForEverySecond>
    {
        public Task Handle(TickerForEverySecond notification, 
            CancellationToken cancellationToken)
        {
            Console.WriteLine(notification.DateTime);
            return Task.CompletedTask;
        }
    }
}