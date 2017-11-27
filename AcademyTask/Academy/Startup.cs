using Academy.Core.Contracts;
using Ninject;
using System.Reflection;

namespace Academy
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            //Composition root
            var karnel = new StandardKernel();
            karnel.Load(Assembly.GetExecutingAssembly());

            karnel.Get<IEngine>().Start();
        }
    }
}
