using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Participant : IParticipant
    {
        public string Name { get ; set ; }

        public Participant(string name)
        {
            Name = name;
        }

        public void Notify(IParticipant participant)
        {
            Console.Clear();
            Console.WriteLine("   Our winner is: {0}", participant.Name);
            Console.WriteLine("   Thanks for playing {0}!", Name);
            Console.ReadLine();
        }
    }
}
