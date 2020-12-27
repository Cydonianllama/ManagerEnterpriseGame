using System;
using System.Runtime.CompilerServices;
using csharpHola.entities;

namespace csharpHola
{ 
    class Program
    {
        public void Options(String option)
        {
            switch (option)
            {
                case "create worker":
                    Console.WriteLine("crear worker");
                    break;
            }
        }
        static void Main()
        {
            Program app = new Program();
            String option = Console.ReadLine();
            app.Options(option);
        }
    }
}
