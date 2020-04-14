using System;
using System.Collections.Generic;
using System.Text;

namespace ITVDN_Les3_Ex2
{
    class ExelentPupil : Pupil
    {
        public new void Study()
        {
            Console.WriteLine("Exelent Studing");
        }
        public new void Read()
        {
            Console.WriteLine("Reading with 100% memorable");
        }
        public new void Write()
        {
            Console.WriteLine("Writing without errors");
        }
        public new void Relax()
        {
            Console.WriteLine("Sport and healthy sleep");
        }
    }
}
