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
    }
}
