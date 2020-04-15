using System;
using System.Collections.Generic;
using System.Text;

namespace ITVDN_Les3_Ex2
{
    class ExelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Exelent Studing");
        }
        public override void Read()
        {
            Console.WriteLine("Reading with 80-100% memorable");
        }
        public override void Write()
        {
            Console.WriteLine("Writing without errors");
        }
        public override void Relax()
        {
            Console.WriteLine("Sport and healthy sleep");
        }
    }
}
