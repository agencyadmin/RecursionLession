using System;

class Programm
{
    static readonly Random random = new Random();

    private static int PowerUp(int N, byte pow)
    {

        if (pow > 1)
        {
            N *= N;
            pow--;
            N = PowerUp(N, pow);
        }
        return N;
    }
    public static void Main(string[] args)
    {

        /*
                Console.WriteLine("Напишите что-то");

                var str = Console.ReadLine();

                Console.WriteLine("Укажите глубину эха");

                var deep = int.Parse(Console.ReadLine());

                for (int i = 0; i < deep; i++)
                {
                    Echo(str, deep);
             // }


                static void Echo(string saidworld, int deep)
                {
                    var list = Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().ToArray();
                    //var ConColor = Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>()
                    var modif = saidworld;
                    if (modif.Length > 2)
                    {
                        modif = modif.Remove(0, 2);
                    }
                    int bcolor = random.Next(15);
                    Console.ForegroundColor = list[bcolor];
                    ConsoleColor deep1 = (ConsoleColor)deep;
                    Console.BackgroundColor = deep1;

                    Console.WriteLine("..." + modif);
                    if (deep > 1)
                    {
                        Echo(modif, deep - 1);
                    }

                }*/
        Console.WriteLine("Введи число для возведения в степень:");

        int result = 0;
        int chislo = int.Parse(Console.ReadLine());
        Console.WriteLine("Введи в какую степень возвести:");
        byte powenter = byte.Parse(Console.ReadLine());
        if (powenter == 0) result = 1;
            else if (powenter == 1) result = chislo;
                else
                {
                     result = PowerUp(chislo,powenter);
                }
        Console.WriteLine($"Результат: {result}");
            
    }
}

