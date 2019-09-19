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
        public bool inFirmMenu;
        public bool inSweepstakesMenu;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
            inFirmMenu = false;
            inSweepstakesMenu = false;
        }

        public void RunFirmMenu()
        {
            UI.DisplaySweepstakesType(manager);
            inFirmMenu = true;

            while (inFirmMenu)
            {
                int userInput = UI.DisplayMarketingFirmMenu();

                switch (userInput)
                {
                    case 1:
                        string nameOfSweepstakes = UI.SetNameOfSweepstakes();
                        Sweepstakes sweepstakes = new Sweepstakes(nameOfSweepstakes);
                        sweepstakes.inSweepstakesMenu = true;
                        while (sweepstakes.inSweepstakesMenu)
                        {
                            sweepstakes.RunSweepstakesMenu(UI.DisplaySweepstakesMenu(sweepstakes.name));
                        }
                        manager.InsertSweepstakes(sweepstakes);
                        break;

                    case 2:
                        bool containsItems = manager.GetCount();
                        if (containsItems)
                        {
                            Sweepstakes returnedSweepstakes = manager.GetSweepstakes();
                            UI.DisplayPastSweepstakes(returnedSweepstakes);
                        }
                        else
                        {
                            UI.DisplayNoSweepstakesStored();
                        }
                        break;

                    case 3:
                        inFirmMenu = false;
                        break;

                    default:
                        RunFirmMenu();
                        break;
                }
            }
        }
    }
}
