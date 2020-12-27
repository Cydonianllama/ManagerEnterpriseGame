using System;
using System.Collections.Generic;
using System.Text;

namespace csharpHola.utils
{
    class Commands
    {
        private static Commands _commands;
        public static Commands GetInstance()
        {
            if(_commands == null)
            {
                _commands = new Commands();
            }
            return _commands;
        }
        public const String CREATE_WORKER = "create worker";
        public const String CREATE_CLIENT = "create client";
        public const String CREATE_TICKET = "create ticket";
        public const String DELETE_TICKET = "delete ticket";
        public const String VERSION_TICKET = "csharpHola --version";
        public const String QUIT_APP = "csharpHola close";
        private Commands() { }
    }
}
