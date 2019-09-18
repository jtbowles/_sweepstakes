using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class QueueManager : ISweepstakesManager
    {
        public string name;
        public Queue<Sweepstakes> db;

        public QueueManager()
        {
            name = "Queue";
            db = new Queue<Sweepstakes>();
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
            db.Enqueue(sweepstakes);
        }
    }
}
