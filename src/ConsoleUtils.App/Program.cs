using System;
using System.Threading;

namespace ConsoleUtils.App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ConsoleLogger.Print("Hello World", NewLine.Yes);

            ConsoleLogger.Print("You can write a message here... ");
            Thread.Sleep(500);

            ConsoleLogger.OK();

            ConsoleLogger.Print("Or show when a warning... ");

            Thread.Sleep(500);

            ConsoleLogger.Warning();

            ConsoleLogger.Print("Indicated that something goes wrong... ");
            Thread.Sleep(500);
            ConsoleLogger.Fail();

            ConsoleLogger.Print("Indicated that something goes wrong and telling what... ");
            Thread.Sleep(500);
            ConsoleLogger.Fail(new Exception());

            ConsoleLogger.Print("You can count on this utility ");

            for (int i = 0; i < 25; i++)
            {
                ConsoleLogger.WriteProcess(i, 24);
                Thread.Sleep(50);
            }

            ConsoleLogger.WriteProcess(50, 25);

            Console.ReadKey();
        }
    }
}