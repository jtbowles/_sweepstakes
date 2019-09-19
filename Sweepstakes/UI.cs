using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UI
    {
        public static string SelectSweepstakesType()
        {
            Console.Clear();
            Console.WriteLine("  ---------------------------------------------------------------");
            Console.WriteLine("   Would you like to store your sweepstakes in a stack or queue?");
            Console.WriteLine("  ---------------------------------------------------------------");
            Console.WriteLine("                    enter [stack] or [queue]");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "stack")
            {
                return userInput;
            }
            else if (userInput == "queue")
            {
                return userInput;
            }
            else
            {
                return SelectSweepstakesType();
            }
        }

        public static void DisplayPastSweepstakes(Sweepstakes sweepstakes)
        {
            Console.Clear();
            Console.WriteLine("  -------------------------------------------------------------------");
            Console.WriteLine("   {0} sweepstakes  | Winner: {1} {2}", sweepstakes.name, sweepstakes.winningContestant.FirstName, sweepstakes.winningContestant.LastName);
            Console.WriteLine("  -------------------------------------------------------------------");
            Console.WriteLine("                     press [enter] to continue");
            Console.ReadLine();
        }

        public static void DisplaySweepstakesType(ISweepstakesManager manager)
        {
            Console.Clear();
            Console.WriteLine("  ------------------------------------------------------------------");
            Console.WriteLine("   Currently using a {0} data structure to store our sweepstakes", manager.GetName());
            Console.WriteLine("  ------------------------------------------------------------------");
            Console.WriteLine("                    press [enter] to continue");
            Console.ReadLine();
        }

        public static void DisplayNoSweepstakesStored()
        {
            Console.Clear();
            Console.WriteLine("  --------------------------------------");
            Console.WriteLine("     No past sweepstakes to display!");
            Console.WriteLine("   Must create a new sweepstakes first!");
            Console.WriteLine("  --------------------------------------");
            Console.WriteLine("        press [enter] to continue");
            Console.ReadLine();
        }

        public static int DisplayMarketingFirmMenu()
        {
            Console.Clear();
            Console.WriteLine("  -------------------------------------");
            Console.WriteLine("   Welcome to the Marketing Firm Menu");
            Console.WriteLine("  -------------------------------------");
            Console.WriteLine("   enter [1] to create a new Sweepstakes");
            Console.WriteLine("   enter [2] to view a past sweepstakes");
            Console.WriteLine("   enter [3] to quit");
            Console.WriteLine("  -------------------------------------");

            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                return userInput;
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(" ----------------------------------------");
                Console.WriteLine("  " + e.Message);
                Console.WriteLine(" ----------------------------------------");
                Console.WriteLine("     please enter a valid response");
                Console.WriteLine(" ----------------------------------------");
                Console.WriteLine("        press [enter] to continue");
                Console.ReadLine();
                Console.Clear();
                return DisplayMarketingFirmMenu();
            }
        }

        public static int DisplaySweepstakesMenu(string name)
        {
            Console.Clear();
            Console.WriteLine("  ----------------------------------------");
            Console.WriteLine("   Welcome to the {0} sweepstakes", name);
            Console.WriteLine("  ----------------------------------------");
            Console.WriteLine("   enter [1] check the number of registered contestants");
            Console.WriteLine("   enter [2] change the number of contestants to register");
            Console.WriteLine("   enter [3] generate contestants");
            Console.WriteLine("   enter [4] to pick a winner");
            Console.WriteLine("  ----------------------------------------");

            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                return userInput;
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(" ----------------------------------------");
                Console.WriteLine("  " + e.Message);
                Console.WriteLine(" ----------------------------------------");
                Console.WriteLine("     please enter a valid response");
                Console.WriteLine(" ----------------------------------------");
                Console.WriteLine("        press [enter] to continue");
                Console.ReadLine();
                Console.Clear();
                return DisplaySweepstakesMenu(name);
            }
        }

        public static bool GetNotificationResponse()
        {
            Console.Clear();
            Console.WriteLine("  ----------------------------------------------------------");
            Console.WriteLine("   Would you like to notify the participants of the winner?");
            Console.WriteLine("  ----------------------------------------------------------");
            Console.WriteLine("                   enter [yes] or [no]");
            string userInput = Console.ReadLine().ToLower();
            if(userInput == "yes")
            {
                return true;
            }
            else if (userInput == "no")
            {
                return false;
            }
            else
            {
                return GetNotificationResponse();
            }
        }

        public static void DisplayCurrentContestantsToRegister(int numberOfContestantsToGenerate)
        {
            Console.Clear();
            Console.WriteLine("  --------------------------------------------");
            Console.WriteLine("   New number of contestants to register: {0}", numberOfContestantsToGenerate);
            Console.WriteLine("  --------------------------------------------");
            Console.WriteLine("         press [enter] to continue");
            Console.ReadLine();
        }

        public static int ChangeNumberOfContestantsToGenerate()
        {
            Console.Clear();
            Console.WriteLine("  --------------------------------------------------------");
            Console.WriteLine("   enter the [number] of contestants you want to generate");
            Console.WriteLine("  --------------------------------------------------------");

            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                return userInput;
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(" ----------------------------------------");
                Console.WriteLine("  " + e.Message);
                Console.WriteLine(" ----------------------------------------");
                Console.WriteLine("     please enter a valid response");
                Console.WriteLine(" ----------------------------------------");
                Console.WriteLine("        press [enter] to continue");
                Console.ReadLine();
                Console.Clear();
                return ChangeNumberOfContestantsToGenerate();
            }
        }

        public static void DisplayContestantsNotGenerated()
        {
            Console.Clear();
            Console.WriteLine("  ----------------------------------------------------");
            Console.WriteLine("   Must register contestants before picking a winner!");
            Console.WriteLine("  ----------------------------------------------------");
            Console.WriteLine("               press [enter] to return");
            Console.ReadLine();
        }

        public static void DisplayWinnerOfSweepstakes(string name, Contestant winner)
        {
            Console.Clear();
            Console.WriteLine("  ----------------------------------------");
            Console.WriteLine("   Winner of the {0} sweepstakes", name);
            Console.WriteLine("  ----------------------------------------");
            Console.WriteLine("   Congratulations to {0} {1}!", winner.FirstName, winner.LastName);
            Console.WriteLine("  ----------------------------------------");
            Console.WriteLine("        press [enter] to continue");
            Console.ReadLine();
        }

        public static void DisplayNumberOfRegisteredContestants(int numOfContestants)
        {
            Console.Clear();
            Console.WriteLine("  ----------------------------------------------");
            Console.WriteLine("   Total number of registered contestants:  {0}", numOfContestants);
            Console.WriteLine("  ----------------------------------------------");
            Console.ReadLine();
        }

        public static string SetNumberOfContestantsToGenerate(int numberOfContestantsToGenerate)
        {
            Console.Clear();
            Console.WriteLine("  -----------------------------------------");
            Console.WriteLine("   Number of contestants to register: {0}", numberOfContestantsToGenerate);
            Console.WriteLine("  -----------------------------------------");
            Console.WriteLine("    would you like to change this number?");
            Console.WriteLine("           enter [yes] or [no]");
            Console.WriteLine("  -----------------------------------------");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static void DisplayRegisteredContestantInfo(Contestant contestant)
        {
            Console.Clear();
            Console.WriteLine("  ------------------------------------");
            Console.WriteLine("   Registered Contestant # {0} ", contestant.RegistrationNumber);
            Console.WriteLine("  ------------------------------------");
            Console.WriteLine("   Full name: {0} {1}", contestant.FirstName, contestant.LastName);
            Console.WriteLine("   Email: {0}", contestant.EmailAddress);
            Console.WriteLine("  ------------------------------------");
            Console.WriteLine("      press [enter] to continue");
            Console.ReadLine();

        }

        public static string SetNameOfSweepstakes()
        {
            Console.Clear();
            Console.WriteLine("  ------------------------------------");
            Console.WriteLine("   Enter the name of this Sweepstakes: ");
            Console.WriteLine("  ------------------------------------");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static string SetContestantFirstName()
        {
            Console.Clear();
            Console.WriteLine("  ------------------------------------");
            Console.WriteLine("   Enter the contestant's first name: ");
            Console.WriteLine("  ------------------------------------");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static string SetContestantLastName()
        {
            Console.Clear();
            Console.WriteLine("  ------------------------------------");
            Console.WriteLine("   Enter the contestant's last name: ");
            Console.WriteLine("  ------------------------------------");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static string SetContestantEmailAddress()
        {
            Console.Clear();
            Console.WriteLine("  ---------------------------------------");
            Console.WriteLine("   Enter the contestant's email address: ");
            Console.WriteLine("  ---------------------------------------");
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
