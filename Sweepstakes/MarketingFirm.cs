using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        public void RunFirmMenu()
        {
            UI.DisplaySweepstakesType(manager);

            int userInput = UI.DisplayMarketingFirmMenu();

            switch (userInput)
            {
                case 1:
                    // Create a new Sweepstakes
                    // SweepstakesMenu
                    break;

                case 2:
                    // Find a Sweepstakes
                    break;

                default:
                    break;
            }
        }
    }
}
