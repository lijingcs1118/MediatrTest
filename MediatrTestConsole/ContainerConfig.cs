using Autofac;

namespace MediatrTestConsole
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<ProgramModule>();
            return builder.Build();
        }
    }
}