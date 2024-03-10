using System.Security.Cryptography;

namespace _3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            
            Console.Write("Введите возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя {0}, ваш возраст {1}", name, age);
            Console.Write("Введите дату рождения: ");
            var birthdate = Console.ReadLine();
            Console.WriteLine("Ваша дата рождения {0}", birthdate);

            Console.ReadKey();
        }
         

            
     
    }
}  
 




        