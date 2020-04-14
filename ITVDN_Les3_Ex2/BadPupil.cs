using System;
using System.Collections.Generic;
using System.Text;

namespace ITVDN_Les3_Ex2
{
    class BadPupil : Pupil
    {
        public new void Study()
        {
            Console.WriteLine("Bad Studing");
        }
        public new void Read()
        {
            Console.WriteLine("Reading with <50% memorable");
        }
        public new void Write()
        {
            Console.WriteLine("Errors! One by one");
        }
        public new void Relax()
        {
            Console.WriteLine("Drinking beer");
        }
    }
}
