using System;
namespace TelegramBot
{
    class Hello 
    {
        static int add(int a, int b) => (a+b);

        public static void Main(string[] args){
            int a = Console.ReadLine();
            int b = Console.ReadLine();
            Console.WriteLine(add(a, b));
            Console.ReadKey();
        }
    }
}