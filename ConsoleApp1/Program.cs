using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Game
    {
        public int vaule; 
        public int number; // количество попыток
        public int res; // результат

        public Game (int numb)
        {
            number = numb;
        }

        public void Random()
        {
            Random rnd = new Random();
            for (int i = 0; i < number; i++)
            {
                vaule = rnd.Next(0, 11); //присваиваем рандомное число
                Console.WriteLine("Введите число от 0 до 10:  ");
                int y = int.Parse(Console.ReadLine());
                if (y == vaule) 
                {
                    res = res + 1;
                    Console.WriteLine("Вы угадали.");
                }
            } 
        }
        public void Result()
        {
            if (res < (number / 2))
            {
                Console.WriteLine("You Lose!!");
                Console.WriteLine($"Вы Угадали {res} раз");
            }
            else if (res > (number / 2))
            {


                Console.WriteLine("You Win!!");
                Console.WriteLine($"Вы Угадали {res} раз");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество попыток: ");
            int a = int.Parse(Console.ReadLine());

            Game gam = new Game(a);

            gam.Random();
            gam.Result();

            Console.ReadKey(); 
        }
    }
}