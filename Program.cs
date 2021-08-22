using System;

namespace MemeToNervoso
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            Console.Beep();
            Console.Clear();

            Console.Write("O que você pensa sobre mim? : ");
            texto = Console.ReadLine();

            Console.Beep();
            Console.WriteLine("E sabe o que eu penso de você?");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{texto.Remove(10)}... NÃO PERA. Tô nervoso");
            Console.ResetColor();

        }
    }
}
