using Academy.Core;
using Academy.Core.Contracts;
using Academy.Core.Factories;
using Academy.Core.Providers;
using Ninject.Modules;

namespace Academy
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IReader>().To<ConsoleReader>().InSingletonScope();
            Bind<IWriter>().To<ConsoleWriter>().InSingletonScope();
            Bind<IParser>().To<CommandParser>().InSingletonScope();

            Bind<IEngine>().To<Engine>().InSingletonScope();

            Bind<IAcademyFactory>().To<AcademyFactory>().InSingletonScope();
            Bind<IDataManager>().To<DataProvider>().InSingletonScope();
        }
    }
}