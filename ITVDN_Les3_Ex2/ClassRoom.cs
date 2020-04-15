using System;
using System.Collections.Generic;
using System.Text;

namespace ITVDN_Les3_Ex2
{
    class ClassRoom
    {
        public ClassRoom(params Pupil[] studs)
        {
            foreach(Pupil pupil in studs)
            {
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
                if (pupil is ExelentPupil) Console.WriteLine("This is exelent pupul");
                else if (pupil is GoodPupil) Console.WriteLine("This is good pupil");
                else Console.WriteLine("This is bad pupil");

                Console.WriteLine(new string('-', 30));
            }
        }
    }
}
