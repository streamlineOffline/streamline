using System;
using System.Collections.Generic;
namespace IEP
{
    public class AreasOfSped
    {
        public string SDI { get; private set; }
        public List<PresentLevels> Goals;

        public AreasOfSped(string sdi, List<PresentLevels> goals)
        {
            SDI = sdi;
            Goals = goals;
        }
    }
}
