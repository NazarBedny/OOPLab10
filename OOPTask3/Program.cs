using OOPTask3.Contracts;
using OOPTask3.Core;
using OOPTask3.Core.Factories;
using OOPTask3.Data;
using System;

namespace OOPTask3
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
