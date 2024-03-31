using System.Globalization;
using System.Net.Cache;
using System.Security.Cryptography;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-то");

            var str = Console.ReadLine();
            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());
           
            Echo(str, deep);
        }
        static void Echo(string saidword, int deep)
        {
            var modif = saidword;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
                Console.WriteLine("..." + modif);
            }
            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }
    }
}




        