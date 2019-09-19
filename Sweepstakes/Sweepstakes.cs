using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> registeredContestants;
        public Contestant winningContestant;
        public int runningNumberOfContestants;
        public int numberOfContestantsToGenerate;
        public string name;
        public bool inSweepstakesMenu;

        public Sweepstakes(string name)
        {
            this.name = name;
            registeredContestants = new Dictionary<int, Contestant>();
            winningContestant = null;
            runningNumberOfContestants = 0;
            numberOfContestantsToGenerate = 5;
            inSweepstakesMenu = false;
        }

        public void RegisterContestant(Contestant contestant)
        {
            registeredContestants.Add(contestant.RegistrationNumber, contestant);
        }

        public Contestant PickWinner()
        {


            Random random = new Random();
            int winningNumber = random.Next(1, runningNumberOfContestants);
            return registeredContestants[winningNumber];
        }

        

        public void PrintContestantInfo(Contestant contestant)
        {
            UI.DisplayRegisteredContestantInfo(contestant);
        }

        public Contestant CreateContestant()
        {
            runningNumberOfContestants++;
            Contestant contestant = new Contestant(runningNumberOfContestants);
            contestant.FirstName = UI.SetContestantFirstName();
            contestant.LastName = UI.SetContestantLastName();
            contestant.EmailAddress = UI.SetContestantEmailAddress();
            return contestant;
        }

        public void GenerateContestants()
        {
            for (int i = 0; i < numberOfContestantsToGenerate; i++)
            {
                Contestant contestant = CreateContestant();
                RegisterContestant(contestant);
                PrintContestantInfo(contestant);
            }
        }

        public void ChangeNumberOfContestantsToGenerate(int numberToChange)
        {
            numberOfContestantsToGenerate = numberToChange;
        }

        public void RunSweepstakesMenu(int sweepCase)
        {
            switch (sweepCase)
            {
                case 1:
                    UI.DisplayNumberOfRegisteredContestants(runningNumberOfContestants);
                    break;

                case 2:
                    string yesNo = UI.SetNumberOfContestantsToGenerate(numberOfContestantsToGenerate);

                    if (yesNo == "yes")
                    {
                        int numToChange = UI.ChangeNumberOfContestantsToGenerate();
                        numberOfContestantsToGenerate = numToChange;
                    }
                    UI.DisplayCurrentContestantsToRegister(numberOfContestantsToGenerate);
                    break;

                case 3:
                    GenerateContestants();
                    break;

                case 4:
                    if (runningNumberOfContestants == 0)
                    {
                        UI.DisplayContestantsNotGenerated();
                        return;
                    }
                    else
                    {
                        winningContestant = PickWinner();
                        UI.DisplayWinnerOfSweepstakes(name, winningContestant);
                        inSweepstakesMenu = false;
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
