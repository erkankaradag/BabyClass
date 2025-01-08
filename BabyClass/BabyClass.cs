using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyClass
{
    public class BabyClass
    {

        // Default Constructor 
        public BabyClass()
        {
           
        }
        // Parametreli Constructor
        public BabyClass(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Console.WriteLine("Ingaaaaaaaaaa");
            dateTime = DateTime.Now;
        }
        private string name;
        private string surname;
        private DateTime dateTime;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public DateTime DateBirth
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        // DAHA ÖNCE DOĞAN BİR BEBEĞİN DEFAULT OLARAK BİLGİSİ GİRİLDİĞİ ZAMAN DOĞUM TARİHİNDE EKRANA OTOMATİK BASILAN 00:00:00 'I KALDIRMAK İÇİN BU METODU KULLANDIM.
        public void PrintScreen()
        {
            Console.WriteLine($"Adı Soyadı: {name} {surname}, doğum tarihi {DateBirth:dd/MM/yyyy}");
        }

        // ANLIK DOĞUM TARİHİ VE BEBEK BİLGİSİ.
        public void PrintScreen2()
        {
            Console.WriteLine($"Adı Soyadı: {name} {surname}, doğum tarihi {dateTime}");
        }
    }
}
