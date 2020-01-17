using System;
namespace IEP
{
    public class Transition
    {
        public string Prefrences { get; private set; }
        public string Interest { get; private set; }
        public string Year { get; private set; }
        public string Credits { get; private set; }

        public Transition(string prefrences, string interest, string year, string credits)
        {
            Prefrences = prefrences;
            Interest = interest;
            Credits = credits;
            Year = year;
        }
    }
}
