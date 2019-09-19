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

        public bool GetCount()
        {
            if(db.Count == 0)
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
            return db.Dequeue();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            db.Enqueue(sweepstakes);
        }
    }
}
