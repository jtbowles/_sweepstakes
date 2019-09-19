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
                        RunSweepstakesMenu(sweepstakes);
                        break;

                    case 2:
                        // Find a Sweepstakes
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

        public void RunSweepstakesMenu(Sweepstakes sweepstakes)
        {
            inSweepstakesMenu = true;

            while (inSweepstakesMenu) 
            {
                int userInput = UI.DisplaySweepstakesMenu(sweepstakes);

                switch (userInput)
                {
                    case 1:
                        UI.DisplayNumberOfRegisteredContestants(sweepstakes);
                        break;

                    case 2:
                        string yesNo = UI.SetNumberOfContestantsToGenerate(sweepstakes);

                        if(yesNo == "yes")
                        {
                            int numToChange = UI.ChangeNumberOfContestantsToGenerate(sweepstakes);
                            sweepstakes.ChangeNumberOfContestantsToGenerate(numToChange);
                        }
                        UI.DisplayCurrentContestantsToRegister(sweepstakes);
                        break;

                    case 3:
                        sweepstakes.GenerateContestants();
                        break;

                    case 4:
                        // pick a winner
                        break;

                    case 5:
                        inSweepstakesMenu = false;
                        // exit
                        // check
                        break;

                    default:
                        RunSweepstakesMenu(sweepstakes);
                        break;
                }
            }
        }

        public void PickSweepstakesWinner(Sweepstakes sweepstakes)
        {
            if(sweepstakes.runningNumberOfContestants == 0)
            {
                UI.DisplayContestantsNotGenerated();
                return;
            }

            Contestant sweepstakesWinner = sweepstakes.PickWinner();

        }
    }
}
