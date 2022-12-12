namespace OOPTask3.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            return (IUnit)Activator.CreateInstance(Type.GetType("OOPTask3.Models."+unitType));
        }
    }
}
