using System;

namespace HelloLib
{
    public class HelloLib
    {
        public static string GetMessage()
        {
            return "Hello from HelloLib.dll";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(GetMessage());
        }
    }
}