using System;

namespace ConsoleUtils
{
    namespace Chroomsoft.ConsoleUtils
    {
        public static class ConsoleLoggerConsts
        {
            static ConsoleLoggerConsts()
            {
                OkMessageText = "[OK]";
                FailMessageText = "[FAIL]";
                WarningMessageText = "[WARNING]";
                OkMessageColour = ConsoleColor.Green;
                FailMessageColour = ConsoleColor.Red;
                WarningMessageColour = ConsoleColor.DarkYellow;
            }

            public static string OkMessageText { get; set; }
            public static string FailMessageText { get; set; }
            public static string WarningMessageText { get; set; }
            public static ConsoleColor OkMessageColour { get; set; }
            public static ConsoleColor FailMessageColour { get; set; }
            public static ConsoleColor WarningMessageColour { get; set; }
        }
    }
}