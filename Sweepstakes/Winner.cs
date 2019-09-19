using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Winner : IParticipant
    {
        public string Name { get ; set ; }

        public Winner(string name)
        {
            Name = name;
        }

        public void Notify(IParticipant participant)
        {
            Console.Clear();
            Console.WriteLine("Congratulations {0}, you won!", participant.Name);
            Console.ReadLine();
        }
    }
}
