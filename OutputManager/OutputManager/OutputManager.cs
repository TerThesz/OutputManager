using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OutputManager
{
    public struct ConsoleOutput
    {

        public static void WriteLine (string message) { FinalOutput(message, true); }
        public static void Write (string message) { FinalOutput(message, false); }

        public static void WriteLine_Status(string message, bool isError) 
        {
            string status = string.Empty;
            switch (isError)
            {
                case true:
                    status = "error";
                    break;
                case false:
                    status = "success";
                    break;
            }
            FinalOutput(message, true, status); 
        }
        public static void Write_Status(string message, bool isError)
        {
            string status = string.Empty;
            switch (isError)
            {
                case true:
                    status = "error";
                    break;
                case false:
                    status = "success";
                    break;
            }
            FinalOutput(message, false, status);
        }

        private static void FinalOutput (string message, bool isNewLine, string status = "default")
        {

            switch (status)
            {

                case "default":
                    if (isNewLine)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"({System.DateTime.Now.ToString("hh:MM:ss")}) ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(message + "\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"({System.DateTime.Now.ToString("hh:MM:ss")}) ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(message);
                    }
                    break;
                case "error":
                    if (isNewLine)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("[");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(" ER ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("]");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"({System.DateTime.Now.ToString("hh:MM:ss")}) ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(message + "\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("[");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(" ER ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("]");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"({System.DateTime.Now.ToString("hh:MM:ss")}) ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(message);
                    }
                    break;
                case "success":
                    if (isNewLine)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("[");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" OK ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("]");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"({System.DateTime.Now.ToString("hh:MM:ss")}) ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(message + "\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("[");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" OK ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("]");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write($"({System.DateTime.Now.ToString("hh:MM:ss")}) ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(message);
                    }
                    break;

            }

            Console.ForegroundColor = ConsoleColor.White;

        }

    }
    public class Loading_Rotating
    {

        public static bool continueLoading = true;
        static Thread thread;

        public static void Start()
        {

            thread = new Thread(Spin);
            thread.Start();

        }
        public static void Spin()
        {

            string[] loadingS = new string[] { "|", "/", "-", "\\" };
            int i = 0;
            while (true)
            {

                Console.Write($"Loading      {loadingS[i]}");
                System.Threading.Thread.Sleep(250);
                ClearCurrentConsoleLine();
                if (i < 3)
                    i++;
                else
                    i = 0;

            }

        }
        public static void Stop()
        {

            if (thread.IsAlive)
                thread.Abort();

        }
        private static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

    }
}
