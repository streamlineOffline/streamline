using System;
using System.Collections.Generic;
namespace IEP
{
    public class AreasOfSped
    {
        public string SDI { get; private set; }
        public List<Goal> Goals;

        public AreasOfSped(string sdi, List<Goal> goals)
        {
            SDI = sdi;
            Goals = goals;
        }
    }
}
