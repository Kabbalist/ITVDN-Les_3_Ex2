using System;
using System.Collections.Generic;
using System.Text;

namespace ITVDN_Les3_Ex2
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good Studing");
        }
        public override void Read()
        {
            Console.WriteLine("Reading with 50-80% memorable");
        }
        public override void Write()
        {
            Console.WriteLine("Writing with small count of errors");
        }
        public override void Relax()
        {
            Console.WriteLine("Walks and sleep");
        }
    }
}
