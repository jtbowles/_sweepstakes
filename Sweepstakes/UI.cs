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
    }
}
