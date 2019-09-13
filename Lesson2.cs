using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jou tüüp");
            Console.ReadLine();
            Console.WriteLine("Kuidas sul läheb?");
            Console.ReadLine();
            string firstName;
            string lastName;
            Console.WriteLine("Super, sisesta palun oma eesnimi:");
            firstName = Console.ReadLine();

            Console.WriteLine("Sisesta palun oma perekonnanimi ka");
            lastName = Console.ReadLine();
            //Console.WriteLine("Tere, " + firstName  + " " + lastName + "!");
            //I'm just a comment
            Console.WriteLine("Tere {0} {1}", firstName, lastName + "!");
            Console.WriteLine("Mis on su lemmikauto?");
            string lemmikauto;
            lemmikauto = Console.ReadLine();
            
            Console.WriteLine("Su lemmikauto on " + lemmikauto + ". Lahe, mulle meeldib ka " + lemmikauto);
           
            lemmikauto = Console.ReadLine();




           
        }
    }
}
