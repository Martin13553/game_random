using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int i =rand.Next(100);
            int count=1;
            Console.WriteLine("У тебя 3 попытки чтобы отгадать число от 0 до 100");
            Console.WriteLine("Введи первое число:");
            int k = Convert.ToInt32(Console.ReadLine());
            while (count <=3)
            {
                
                if (i == k)
                 {
                Console.WriteLine(" Компьютер загадал число "+k+"!");
                break;
                 }
              else
                 {
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine("Увы, вы не отгодали загаданное число. Это было число " + i + "!");
                        break;
                    }
                    Console.WriteLine("Нет, это не число " + k + "! Попытка № "+ count+":");
                    k = Convert.ToInt32(Console.ReadLine()); 
                 }  
            }
            Console.ReadLine();
        }
    }
}
