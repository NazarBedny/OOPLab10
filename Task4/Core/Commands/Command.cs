using OOPTask4.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Core.Commands
{
    public abstract class Command : IExecutable
    {
        private string[] data;
        private IRepository repository;
        private IUnitFactory unitFactory;

        protected Command(string[] data, IRepository repository, IUnitFactory unitFactory)
        {
            this.Data = data;
            this.Repository = repository;
            this.UnitFactory = unitFactory;
        }

        protected string[] Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        protected IRepository Repository
        {
            get { return this.repository; }
            set { this.repository = value; }
        }

        protected IUnitFactory UnitFactory
        {
            get { return this.unitFactory; }
            set { this.unitFactory = value; }
        }

        public abstract string Execute();
    }
}
