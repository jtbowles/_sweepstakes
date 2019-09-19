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

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
            inFirmMenu = false;
        }

        public void StartProgram()
        {
            inFirmMenu = true;
            UI.DisplaySweepstakesType(manager);
            while (inFirmMenu)
            {
                int userInput = UI.DisplayMarketingFirmMenu();
                RunFirmMenu(userInput);
            }
        }

        public void RunFirmMenu(int userInput)
        {

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
                    break;
            }
            
        }
    }
}
