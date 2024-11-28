using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Zadanie5 : Program
    {
        private int counter = 1;
        private Random rnd;
        private int randomNum;
        private int userInput;

        public Zadanie5()
        {
            rnd = new Random();
            randomNum = rnd.Next(0, 101);
        }

        public void Start()
        {
            Console.WriteLine("Liczba jest zginerowana\n"+"Podaj liczbę 0 - 100: \n"+
                "Napisz 112 jeśli chcesz skończyć");
            int userInput = Parser(Console.ReadLine());

            while (userInput != randomNum)
            {
                counter++;
                if (userInput == 112)
                {
                    Console.WriteLine("Dziękuję za grę");
                    break;
                }
                else if (userInput > randomNum)
                {
                    Console.WriteLine("Twoja liczba jest większa");
                }
                else
                {
                    Console.WriteLine("Twoja liczba jest mniejsza");
                }
                userInput = Parser(Console.ReadLine());
            }
            Console.WriteLine($"Ilość prób: {counter}");
        }
    }
}
