﻿namespace OOPTask4.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            return (IUnit)Activator.CreateInstance(Type.GetType("OOPTask4.Models."+unitType));
        }
    }
}
