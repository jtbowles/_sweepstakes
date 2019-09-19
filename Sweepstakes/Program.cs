﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            SweepstakesFactory factory = new SweepstakesFactory();
            string userInput = UI.SelectSweepstakesType();
            ISweepstakesManager manager = factory.SetSweepstakesDataStructure(userInput);

            MarketingFirm marketingFirm = new MarketingFirm(manager);
            marketingFirm.RunFirmMenu();
        }
    }
}
