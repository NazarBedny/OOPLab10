using OOPTask4.Contracts;
using OOPTask4.Core;
using OOPTask4.Core.Factories;
using OOPTask4.Data;
using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository repository = new UnitRepository();
            IUnitFactory unitFactory = new UnitFactory();
            IRunnable engine = new Engine(repository, unitFactory);
            engine.Run();
        }
    }
}
