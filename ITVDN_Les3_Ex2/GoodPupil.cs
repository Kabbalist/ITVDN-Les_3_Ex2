using System;
using System.Collections.Generic;
using System.Text;

namespace ITVDN_Les3_Ex2
{
    class GoodPupil : Pupil
    {
        public new void Study()
        {
            Console.WriteLine("Good Studing");
        }
        public new void Read()
        {
            Console.WriteLine("Reading with 50-100% memorable");
        }
        public new void Write()
        {
            Console.WriteLine("Writing with small count of errors");
        }
        public new void Relax()
        {
            Console.WriteLine("Walks and sleep");
        }
    }
}
