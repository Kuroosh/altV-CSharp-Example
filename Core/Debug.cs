using System;
using System.Runtime.CompilerServices;

namespace CykaBlyat.Core
{
    public static class Debug
    {
        public static void CatchException(Exception ex, [CallerMemberName]string funcName = "")
        {
            string[] text = { "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~", "[EXCEPTION " + funcName + "] " + ex.Message, "[EXCEPTION " + funcName + "] " + ex.StackTrace };
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text[0]);
            Console.WriteLine(text[1]);
            Console.WriteLine(text[2]);
            Console.WriteLine(text[0]);
            Console.ResetColor();
        }
    }
}