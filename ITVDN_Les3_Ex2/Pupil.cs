using System;

namespace ITVDN_Les3_Ex2
{
    class Pupil
    {
        virtual public void Study()
        {
            Console.WriteLine("Studing");
        }
        virtual public void Read()
        {
            Console.WriteLine("Reading");
        }
        virtual public void Write()
        {
            Console.WriteLine("Writing");
        }
        virtual public void Relax()
        {
            Console.WriteLine("Relaxing");
        }
    }
}
