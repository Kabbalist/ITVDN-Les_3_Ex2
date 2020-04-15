using System;
using System.Collections.Generic;
using System.Text;

namespace ITVDN_Les3_Ex2
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad Studing");
        }
        public override void Read()
        {
            Console.WriteLine("Reading with <50% memorable");
        }
        public override void Write()
        {
            Console.WriteLine("Errors! One by one");
        }
        public override void Relax()
        {
            Console.WriteLine("Drinking beer");
        }
    }
}
