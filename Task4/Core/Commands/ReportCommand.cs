using OOPTask4.Contracts;

namespace Task4.Core.Commands
{
    public class ReportCommand : Command
    {
        public ReportCommand(string[] data, IRepository repository, IUnitFactory unitFactory)
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string output = Repository.Statistics;
            return output;
        }
    }
}
