using Lab1;
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Co chcesz zrobić?\n" +
        "Użyj 1, jeśli chcesz dowiedzieć się, czy liczba jest parzysta.\n" +
        "Użyj 2, jeśli chcesz zbudować ciąg.\n" +
        "Użyj 3, jeśli chcesz policzyć siłną.\n" +
        "Użyj 4, jeśli chcesz zgadąć liczbę.\n" +
        "Użyj stop, jeśli chcesz skończyć");
        bool flag = true;

        string UserInput = Console.ReadLine();

        while (flag)
        {
            if (UserInput == "stop")
            {
                flag = false;
                break;
            }
            else if (UserInput == "1")
            {
                Console.WriteLine("Podaj Liczbę: ");
                string AnotherUserInput = Console.ReadLine();

                if (AnotherUserInput == "stop") { flag = false; break;  }

                Zadanie1 zadanie1 = new Zadanie1(Parser(AnotherUserInput));
                Console.WriteLine(zadanie1.Checker());
            }
            else if (UserInput == "2")
            {
                Console.WriteLine("Podaj Liczbę: ");
                string AnotherUserInput = Console.ReadLine();

                if (AnotherUserInput == "stop") { flag = false; break; }

                Zadanie2 zadanie2 = new Zadanie2(Parser(AnotherUserInput));
                Console.WriteLine(zadanie2.ArrayDeveloper());
            }
            else if (UserInput == "3")
            {
                Console.WriteLine("Podaj Liczbę: ");
                string AnotherUserInput = Console.ReadLine();

                if (AnotherUserInput == "stop") { flag = false; break; }

                Console.WriteLine(Zadanie4.Factorial(5));
            }
            else if (UserInput == "4")
            {
                Zadanie5 zadanie5 = new Zadanie5();
                zadanie5.Start();
            }
            else
            {
                Console.WriteLine("Nieprawidłowy wybór, spróbuj ponownie.");
            }
        }
    }

    public static int Parser(string UserInput)
    {
        if (int.TryParse(UserInput, out int result))
        {
            return result; 
        }
        else
        {
            throw new Exception("Bląd");
        }
    }
}

class Zadanie1
{
    private int Num { get; set; }

    public Zadanie1(int num)
    {
        Num = num;
    }
    public string Checker()
    {
        if (Num % 2 == 0)
        {
            return "Parzysta";
        }
        else
        {
            return"Nie parzysta";
        }
    }
}

class Zadanie2
{
    private int Num { get; set; }

    public Zadanie2(int num)
    {
        Num = num;
    }
    public string ArrayDeveloper()
    {
        List<int> ints = new List<int>();
        for (int i = 1; i <= Num; i++)
        {
            ints.Add(i);
        }
        return string.Join(", ", ints);
    }
}

class Zadanie4
{
    public static int Factorial(int num)
    {
        if (num == 0)
        {
            return 1;
        }
        else
        {
            return num * Factorial(num - 1);
        }
    }
}

