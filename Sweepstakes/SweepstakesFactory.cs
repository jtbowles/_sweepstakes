using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesFactory 
    {

        public ISweepstakesManager SetSweepstakesDataStructure()
        {
            string userInput = UI.SelectSweepstakesType();

            switch (userInput)
            {
                case "stack":
                    return new StackManager();

                case "queue":
                    return new QueueManager();

                default:
                    return SetSweepstakesDataStructure();
            }
        }

    }
}
