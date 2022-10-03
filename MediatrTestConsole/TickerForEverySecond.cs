using System;
using MediatR;

namespace MediatrTestConsole
{
    public class TickerForEverySecond:INotification
    {
        public TickerForEverySecond(DateTime dateTime)
        {
            DateTime = dateTime;
        }

        public DateTime DateTime { get; }
    }
}