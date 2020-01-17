using System;
using System.Collections.Generic;
namespace IEP
{
    public class Classes
    {
        public bool Sped { get; private set; }
        public int Period { get; private set; }
        public int Priority { get; private set; }
        public string Subject { get; private set; }
        public string Teacher { get; private set; }


        public bool isSpedClass()
        {
            string input = "";
            while (true)
            {
                input = Console.ReadLine();
                input.ToLower();
                if (input == "f")
                {
                    return false;
                }
                else if (input == "t")
                {
                    return true;
                }
                else
                    Console.WriteLine("you wrote '" + input + "', Please use 't' or 'f'");
            }
        }
        /*
                public Classes(string teacher, string subject, int priority, int period, bool sped)
                {
                    Teacher = teacher;
                    Subject = subject;
                    Priority = priority;
                    Period = period;
                    Sped = sped;
                }
                */
        public Classes()
        {
        }
        public Classes(bool sped, string subject)
        {
            Sped = sped;
            Subject = subject;
        }
    }
}
