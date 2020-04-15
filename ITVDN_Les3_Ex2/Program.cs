using System;

namespace ITVDN_Les3_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            ExelentPupil exPup = new ExelentPupil();
            GoodPupil gdPup = new GoodPupil();
            BadPupil bdPup = new BadPupil();
            ClassRoom class1 = new ClassRoom(exPup, bdPup, gdPup);
            
            Console.ReadKey();
        }
    }
}
