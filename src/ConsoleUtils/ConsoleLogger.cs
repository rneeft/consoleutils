using Chroomsoft.Console;

namespace System
{
    public class ConsoleLogger
    {
        private static string lastWrite = string.Empty;

        /// <summary>
        /// Prints the message
        /// </summary>
        public static void Print(string message, NewLine newLine = NewLine.No)
        {
            if (newLine == NewLine.Yes)
            {
                Console.WriteLine(message);
                lastWrite = string.Empty;
            }
            else
            {
                Console.Write(message);
                lastWrite = message;
            }
        }

        /// <summary>
        /// Prints the message in the specified colour on the Console
        /// </summary>
        public static void Print(string message, ConsoleColor colour, NewLine newLine = NewLine.No)
        {
            var beforeColour = Console.ForegroundColor;
            Console.ForegroundColor = colour;

            Print(message, newLine);

            Console.ForegroundColor = beforeColour;
        }

        /// <summary>
        /// Prints [OK] in green with a new line to the console
        /// </summary>
        public static void OK()
        {
            Print(ConsoleLoggerConsts.OkMessageText, ConsoleLoggerConsts.OkMessageColour, NewLine.Yes);
        }

        /// <summary>
        /// Prints [WARNING] in yellow with a new line to the console
        /// </summary>
        public static void Warning()
        {
            Print(ConsoleLoggerConsts.WarningMessageText, ConsoleLoggerConsts.WarningMessageColour, NewLine.Yes);
        }

        /// <summary>
        /// Prints [FAIL] in red with a new line to the console
        /// </summary>
        public static void Fail()
        {
            Print(ConsoleLoggerConsts.FailMessageText, ConsoleLoggerConsts.FailMessageColour, NewLine.Yes);
        }

        /// <summary>
        /// Prints [FAIL] and the ToString of the exception in red to the console
        /// </summary>
        public static void Fail(Exception ex)
        {
            Fail();
            Print(ex.ToString(), ConsoleLoggerConsts.FailMessageColour, NewLine.Yes);
        }

        /// <summary>
        /// Prints a 'press a key' message and waits for the user to press a key
        /// </summary>
        public static void Wait()
        {
            Console.Write(ConsoleLoggerConsts.WaitingMessageText);
            Console.ReadKey();
            Console.WriteLine(string.Empty);
        }

        /// <summary>
        /// Draws a process bar to the Console window and ends with [OK]
        /// </summary>
        /// <param name="part"></param>
        /// <param name="whole"></param>
        public static void WriteProcess(int part, int whole)
        {
            var process = part * 100 / whole;

            if (process > 100)
                process = 100;

            var lineToPrint = $"{lastWrite} [".Trim();

            for (int i = 0; i < process / 5; i++)
                lineToPrint += "#";

            for (int i = 0; i < 20 - process / 5; i++)
                lineToPrint += " ";

            lineToPrint += "] ";

            Console.Write("\r" + lineToPrint);

            if (process < 100)
                Console.Write($"{process}%");
            else
                OK();
        }
    }
}