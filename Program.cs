using System;

class Programm
{
    static readonly Random random = new Random();
    
    public static void Main(string[] args)
    {
        

        Console.WriteLine("Напишите что-то");

        var str = Console.ReadLine();

        Console.WriteLine("Укажите глубину эха");

        var deep = int.Parse(Console.ReadLine());

        /*for (int i = 0; i < deep; i++)
        {*/
            Echo(str, deep);
     // }
        

        static void Echo(string saidworld, int deep)
        {
            var list = Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().ToArray();
            var modif = saidworld;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }
            int bcolor = random.Next(14);
            Console.ForegroundColor = list[bcolor];
            Console.WriteLine("..." + modif);
            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }
    }
}

