using System;

class Programm
{
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
            var modif = saidworld;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }
            Console.WriteLine("..." + modif);
            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }
    }
}

