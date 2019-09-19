using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> registeredContestants = new Dictionary<int, Contestant>();
        List<IParticipant> participants = new List<IParticipant>();
        public IParticipant winner = null;
        public Contestant winningContestant = null;
        public int runningNumberOfContestants = 0;
        public int numberOfContestantsToGenerate = 5;
        public string name;
        public bool inSweepstakesMenu = false;

        public Sweepstakes(string name)
        {
            this.name = name;
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

        public void Subscribe(IParticipant participant)
        {
            participants.Add(participant);
        }

        public void NotifyParticipants()
        {
            foreach (IParticipant participant in participants)
            {
                participant.Notify(winner);
            }
        }

        public void GenerateParticipants()
        {
            IParticipant participant;

            for (int i = 1; i <= registeredContestants.Count; i++)
            {
                if(registeredContestants[i] == winningContestant)
                {
                    string name = registeredContestants[i].FirstName + " " + registeredContestants[i].LastName;
                    participant = new Winner(name);
                    winner = participant;
                }
                else
                {
                    participant = new Participant(registeredContestants[i].FirstName);

                }
                Subscribe(participant);
            }
        }

        public void NotifyParticipantsPrompt()
        {
            bool yesNo = UI.GetNotificationResponse();

            if (yesNo)
            {
                GenerateParticipants();
                NotifyParticipants();
            }
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
                        NotifyParticipantsPrompt();
                        inSweepstakesMenu = false;
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
