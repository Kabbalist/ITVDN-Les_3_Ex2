using System;

namespace ITVDN_Les3_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            ExelentPupil exPup = new ExelentPupil();
            ClassRoom class1 = new ClassRoom(exPup);
            Console.ReadKey();
        }
    }
}
