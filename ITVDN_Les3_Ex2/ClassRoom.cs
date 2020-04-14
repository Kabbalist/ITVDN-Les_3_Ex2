using System;
using System.Collections.Generic;
using System.Text;

namespace ITVDN_Les3_Ex2
{
    class ClassRoom
    {
        public ClassRoom(params Pupil[] studs)//(Pupil first, Pupil second, Pupil third, Pupil fourth)
        {
            foreach(Pupil pupil in studs)
            {
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
                //pupil.ToString();
            }
        }
    }
}
