using System;
using System.Runtime.CompilerServices;
using csharpHola.entities;
using csharpHola.controllers;
using System.Collections.Generic;
using csharpHola.utils;

namespace csharpHola
{
    class myGeneric<T>
    {
        public bool isCorrect;
        public List<T> a;
    }

    class Program
    {
        private static bool isRunning = true;

        public static void CloseApp()
        {
            isRunning = false;
        }
        private static void Options(String option)
        {
            ControllerTicket CTicket = new ControllerTicket();
            switch (option)
            {
                case Commands.CREATE_CLIENT:
                    controllerCliente CCliente = null;
                    CCliente = new controllerCliente();
                    CCliente.CreateClient();
                    Console.WriteLine("craete client instance");
                    break;
                case Commands.CREATE_WORKER:
                    break;
                case Commands.CREATE_TICKET:
                    DateTime a = new DateTime(2020, 12, 20);
                    CTicket.CreateTicket("555",a,"111","195");
                    Store.GetInstance().tickets.ForEach(p => Console.WriteLine(p.ClientCode));//test
                    break;
                case Commands.DELETE_TICKET:
                    CTicket.DestroyTicket("195");
                    break;
                case Commands.VERSION_TICKET:
                    Console.WriteLine("version 0.6 estimated");
                    break;
                case Commands.QUIT_APP:
                    CloseApp();
                    break;
            }
        }
        public static void LoopApp()
        {
            while (Program.isRunning == true)
            {
                String option = Console.ReadLine();
                Program.Options(option);
            }
        }
        static void Main()
        {
            dynamic hola = "555";
            hola = 32;
            Program app = new Program();
            LoopApp();
        }
    }
}
