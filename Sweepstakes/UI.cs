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
            Console.WriteLine("                 enter [stack] or [queue]");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static void DisplaySweepstakesType(ISweepstakesManager manager)
        {
            Console.Clear();
            Console.WriteLine("   Currently using a {0} manager to store our sweepstakes", manager.GetName());
            Console.WriteLine("               press [enter] to continue");
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
