using System;

namespace Chroomsoft.Console
{
    public static class ConsoleLoggerConsts
    {
        static ConsoleLoggerConsts()
        {
            LoadDefaults();
        }

        public static string OkMessageText { get; set; }
        public static string FailMessageText { get; set; }
        public static string WarningMessageText { get; set; }
        public static string WaitingMessageText { get; set; }
        public static ConsoleColor OkMessageColour { get; set; }
        public static ConsoleColor FailMessageColour { get; set; }
        public static ConsoleColor WarningMessageColour { get; set; }

        public static void LoadDefaults()
        {
            OkMessageText = "[OK]";
            FailMessageText = "[FAIL]";
            WarningMessageText = "[WARNING]";
            WaitingMessageText = "Please press a key to continue...";
            OkMessageColour = ConsoleColor.Green;
            FailMessageColour = ConsoleColor.Red;
            WarningMessageColour = ConsoleColor.DarkYellow;
        }
    }
}