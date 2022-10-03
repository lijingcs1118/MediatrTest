using Autofac;
using Autofac.Core;
using Autofac.Core.Registration;
using MediatR.Extensions.Autofac.DependencyInjection;

namespace MediatrTestConsole
{
    public class ProgramModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterMediatR(typeof(Program).Assembly);
            builder.RegisterType<TickBackgroundService>().AsSelf();
        }
    }
}