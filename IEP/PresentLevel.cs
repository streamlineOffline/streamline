using System;
namespace IEP
{
    public class PresentLevels
    {
        public string SubArea { get; private set; }
        public string PreviousGoal { get; private set; }
        public string NextGoal { get; private set; }
        public string Status { get; private set; }

        public PresentLevels(string subArea, string previousGoal, string status, string nextGoal)
        {
            SubArea = subArea;
            PreviousGoal = previousGoal;
            Status = status;
            NextGoal = nextGoal;
        }
    }
}
