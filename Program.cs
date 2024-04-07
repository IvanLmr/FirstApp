using System.Drawing;
using System.Globalization;
using System.Net.Cache;
using System.Security.Cryptography;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserAnketa();

            Console.ReadKey();
        }
        static (string Name, string LastName, int Age, int Pet, int Collor) UserAnketa()
        {
            (string Name, string LastName, int Age, int Pet, int Color) User;

            Console.Write("Введите имя: ");
            User.Name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            User.LastName = Console.ReadLine();
            string age;
            int intage;
            do
            {
                Console.Write("Введите возраст: ");
                age = Console.ReadLine();
            }
            while (CheckNum(age, out intage));
            User.Age = intage;

            int intPet = new int(); 

            string howPet; 

            string petText = "";  

            string yesno; 

            do
            {
                Console.Write("Есть ли у Вас домашине питомцы? (Да/Нет) ");

                yesno = Console.ReadLine();

                if (yesno.ToLower() == "да")

                {
                    do
                    {
                        Console.WriteLine("Сколько питомцев у Вас? ");
                        howPet = Console.ReadLine();
                    }
                    while (CheckNum(howPet, out intPet));

                }

                else if (yesno.ToLower() == "нет")
                {
                    petText = "питомцев";
                }
            }
            while (yesNo(yesno));


            if (Convert.ToInt32(intPet) == 1)
            {
                Console.WriteLine("Как его/ее зовут? ");
                petText = "питомец, его/ее зовут";
            }

            else if (Convert.ToInt32(intPet) > 1)
            {
                Console.WriteLine("Как их зовут? ");
                petText = "питомца, их зовут";
            }

            string[] namePets = new string[intPet];

            for (int i = 0; i < namePets.Length; i++)
            {
                namePets[i] = Console.ReadLine();
            }

            string namePett = string.Join(", ", namePets);

            User.Pet = intPet;

            string collor;
            int intCollor;
            string collortxt;

            do
            {
                Console.WriteLine("Сколько у вас любимых цветов?");
                collor = Console.ReadLine();
            }
            while (CheckNum(collor, out intCollor));

            if (intCollor == 1)
            {
                Console.WriteLine("Назовите цвет: ");
                collortxt = "любимый цвет - это ";
            }
            else
            {
                Console.WriteLine("Назовите цвета");
                collortxt = "любимых цвета";
            }

            string[] nameCollors = new string[intCollor];
            for (int i = 0; i < nameCollors.Length; i++)
            {
                nameCollors[i] = Console.ReadLine();
            }
            string nameColl = string.Join(", ", nameCollors);
            User.Color = intCollor;


            Console.Write($"Ваше имя {User.Name}, Ваша фамилия {User.LastName}, Вам {User.Age}, лет\nУ вас {User.Pet} {petText} {namePett},\nУ вас {User.Color} {collortxt} {nameColl}");
            return User;
        }

        static bool CheckNum(string number, out int cornumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    cornumber = intnum;
                    return false;
                }
            }
            {
                cornumber = 0;
                return true;
            }
        }

        static bool ChekSymbol(string symbol)
        {

            if (string.IsNullOrEmpty(symbol))
                return true;
            else
                return false;
        }

        static bool yesNo(string yesno)
        {
            if (yesno.ToLower() == "да" || yesno.ToLower() == "нет")
                return false;
            else
                return true;
        }
    }
}




        