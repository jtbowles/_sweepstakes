using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class StackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> db = new Stack<Sweepstakes>();

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
