using System;
namespace BabyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------Parametresiz Constructor------------------");
            BabyClass newbornBaby = new BabyClass
            {
                Name = "Adem",
                Surname = "Demir",
                DateBirth = new DateTime(2025, 01, 01)
            };
            newbornBaby.PrintScreen();

            Console.WriteLine("------------------Parametreli Constructor---------------------");

            BabyClass newbornBaby2 = new BabyClass("Arif","Çiçek");
            newbornBaby2.PrintScreen2();





        }
    }
}