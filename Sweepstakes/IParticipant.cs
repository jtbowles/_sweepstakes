using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public interface IParticipant
    {
        string Name { get; set; }
        void Notify(IParticipant participant);
    }
}
