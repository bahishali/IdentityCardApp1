using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityCardApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Busra");
            //Write komutu ilgili satırın yanında devam eder
            //Console.Write("Ahıshalı");
            Console.WriteLine("****** Kimlik *****"); //Header
            Console.WriteLine();//araya bi satır boşluk koymuş olduk
            Console.WriteLine("Busra");
            //WriteLine komutu ilgili satırın altına devam eder
            Console.WriteLine("Ahıshalı");
            Console.WriteLine("İstanbul Teknik Üniversitesi");
            Console.WriteLine("Çorum");
            Console.WriteLine();
            Console.Write("****** Kimlik *****"); //Footer
            Console.Read();
        }
    }
}
