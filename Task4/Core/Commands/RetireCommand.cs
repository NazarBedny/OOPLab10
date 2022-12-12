using OOPTask4.Contracts;
using System;

namespace Task4.Core.Commands
{
    public class RetireCommand : Command
    {
        public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory)
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            var typeOfUnit = Data[1];

            try
            {
                Repository.RemoveUnit(typeOfUnit);
                return $"{typeOfUnit} retired!";
            }
            catch (ArgumentException e)
            {
                return e.Message;
            }
        }
    }
}
