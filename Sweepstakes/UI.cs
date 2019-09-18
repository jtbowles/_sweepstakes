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
            Console.WriteLine("   Would you like to store your sweepstakes in a stack or queue?");
            Console.WriteLine("  ---------------------------------------------------------------");
            Console.WriteLine("                  enter [stack] or [queue]");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static void DisplaySweepstakesType(ISweepstakesManager manager)
        {
            Console.Clear();
            Console.WriteLine("   Currently using a {0} manager to store our sweepstakes", manager.GetName());
            Console.WriteLine("  ---------------------------------------------------------");
            Console.WriteLine("                  press [enter] to continue");
        }

        public static int DisplayMarketingFirmMenu()
        {
            Console.Clear();
            Console.WriteLine("   Welcome to the Marketing Firm Menu");
            Console.WriteLine("  --------------------------------------");
            Console.WriteLine("   enter [1] to create a new Sweepstakes");
            Console.WriteLine("   enter [2] to view a past sweepstakes");
            Console.WriteLine("   enter [3] to quit");
            int userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }

        public static int DisplaySweepstakesMenu(Sweepstakes sweepstakes)
        {
            Console.Clear();
            Console.WriteLine("   Welcome to the {0} sweepstakes", sweepstakes.name);
            Console.WriteLine("  --------------------------------------");
            Console.WriteLine("   enter [1] check the number of registered contestants");
            Console.WriteLine("   enter [2] change the number of contestants to register");
            Console.WriteLine("   enter [3] generate contestants");
            Console.WriteLine("   enter [4] to pick a winner");
            Console.WriteLine("   enter [5] to quit");
            int userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }

        public static void DisplayCurrentContestantsToRegister(Sweepstakes sweepstakes)
        {
            Console.Clear();
            Console.WriteLine("   New number of contestants to register: {0}", sweepstakes.numberOfContestantsToGenerate);
            Console.WriteLine("  --------------------------------------------");
            Console.WriteLine("         press [enter] to continue");
            Console.ReadLine();
        }

        public static int ChangeNumberOfContestantsToGenerate(Sweepstakes sweepstakes)
        {
            Console.Clear();
            Console.WriteLine("   enter the [number] of contestants you want to generate");
            Console.WriteLine("  --------------------------------------------------------");
            int userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }

        public static void DisplayNumberOfRegisteredContestants(Sweepstakes sweepstakes)
        {
            Console.Clear();
            Console.WriteLine("   Total number of registered contestants:  {0}", sweepstakes.runningNumberOfContestants);
            Console.WriteLine("  ----------------------------------------------");
            Console.ReadLine();
        }

        public static string SetNumberOfContestantsToGenerate(Sweepstakes sweepstakes)
        {
            Console.Clear();
            Console.WriteLine("   Number of contestants to register: {0}", sweepstakes.numberOfContestantsToGenerate);
            Console.WriteLine("  -----------------------------------------");
            Console.WriteLine("    would you like to change this number?");
            Console.WriteLine("           enter [yes] or [no]");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static void DisplayRegisteredContestantInfo(Contestant contestant)
        {
            Console.Clear();
            Console.WriteLine("   Registered Contestant # {0} ", contestant.RegistrationNumber);
            Console.WriteLine("  ------------------------------------");
            Console.WriteLine("   Full name: {0} {1}", contestant.FirstName, contestant.LastName);
            Console.WriteLine("   Email: {0}", contestant.EmailAddress);
            Console.WriteLine("  ------------------------------------");
            Console.ReadLine();

        }

        public static string SetNameOfSweepstakes()
        {
            Console.Clear();
            Console.WriteLine("   Enter the name of this Sweepstakes: ");
            Console.WriteLine("  ------------------------------------");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static string SetContestantFirstName()
        {
            Console.Clear();
            Console.WriteLine("   Enter the contestant's first name: ");
            Console.WriteLine("  ------------------------------------");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static string SetContestantLastName()
        {
            Console.Clear();
            Console.WriteLine("   Enter the contestant's last name: ");
            Console.WriteLine("  ------------------------------------");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static string SetContestantEmailAddress()
        {
            Console.Clear();
            Console.WriteLine("   Enter the contestant's email address: ");
            Console.WriteLine("  ---------------------------------------");
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
