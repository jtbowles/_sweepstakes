using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class QueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> db = new Queue<Sweepstakes>();

        public Sweepstakes GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            db.Enqueue(sweepstakes);
        }
    }
}
