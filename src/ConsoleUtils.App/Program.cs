using System;
using System.Threading;

namespace Chroomsoft.ConsoleUtilities.App
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

            ConsoleLogger.Wait();

            ConsoleLogger.Print("You can also change the text and colour by using ");
            ConsoleLogger.Print($"{nameof(ConsoleLoggerConsts)}", ConsoleColor.Cyan);
            ConsoleLogger.Print(" class", NewLine.Yes);

            ConsoleLoggerConsts.OkMessageText = "[READY?]";
            ConsoleLoggerConsts.OkMessageColour = ConsoleColor.Blue;

            ConsoleLogger.OK();

            ConsoleLoggerConsts.WaitingMessageText = "Press a key to exit";

            ConsoleLogger.Wait();
        }
    }
}