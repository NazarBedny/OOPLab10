namespace OOPTask4.Data 
{ 
    using System;
    using Contracts;
    using System.Collections.Generic;
    using System.Text;
    class UnitRepository : IRepository
    {
        private IDictionary<string, int> amountOfUnits;

        public UnitRepository()
        {
            amountOfUnits = new SortedDictionary<string, int>();
        }

        public string Statistics
        {
            get
            {
                StringBuilder statBuilder = new StringBuilder();
                foreach (var entry in amountOfUnits)
                {
                    string formatedEntry =
                            string.Format("{0} -> {1}", entry.Key, entry.Value);
                    statBuilder.AppendLine(formatedEntry);
                }

                return statBuilder.ToString().Trim();
            }
        }

        public void AddUnit(IUnit unit)
        {
            string unitType = unit.GetType().Name;
            if (!amountOfUnits.ContainsKey(unitType))
            {
                amountOfUnits.Add(unitType, 0);
            }

           amountOfUnits[unitType]++;
        }

        public void RemoveUnit(string unitType)
        {
            //TODO: implement for Problem 4
            if (amountOfUnits.ContainsKey(unitType) &&amountOfUnits[unitType] > 0)
            {
                amountOfUnits[unitType]--;
            }
            else
            {
                throw new ArgumentException("No such units in repository.");
            }
        }
    }
}
