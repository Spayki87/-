using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string zodiacSigh;
            string job;
            Console.Write("Введите ваше имя:");
            name = Console.ReadLine();
            Console.Write("Введите ваш возраст:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ваш знак зодиака:");
            zodiacSigh = Console.ReadLine();
            Console.Write("Введите место вашей работы:");
            job = Console.ReadLine();
            Console.WriteLine("Вас зовут - " + name + ", вам - " + age + " лет, по зодиаку вы " + zodiacSigh + " и работаете в " + job + ".");
        }
    }
}
