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

        public bool GetCount()
        {
            if (db.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string GetName()
        {
            return name;
        }

        public Sweepstakes GetSweepstakes()
        {
            return db.Pop();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            db.Push(sweepstakes);
        }
    }
}
