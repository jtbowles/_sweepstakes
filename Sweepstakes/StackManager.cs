using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class StackManager : ISweepstakesManager
    {
        public string name;
        public Stack<Sweepstakes> db;

        public StackManager()
        {
            name = "Stack";
            db = new Stack<Sweepstakes>();
        }

        public string GetName()
        {
            return name;
        }

        public Sweepstakes GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            db.Push(sweepstakes);
        }
    }
}
