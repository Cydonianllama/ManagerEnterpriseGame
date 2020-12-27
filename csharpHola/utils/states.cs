using System;
using System.Collections.Generic;
using System.Text;

namespace csharpHola.utils
{
    class States
    {
        private static States _states;
        public static States getInstance()
        {
            if(_states == null)
            {
                _states = new States();
            }
            return _states;
        }

        public static String CLIENT_CREATE_REQUEST = "CLIENT_CREATE_REQUEST";
        public static String CLIENT_CREATE_SUCCESS = "CLIENT_CREATE_SUCCESS";
        public static String CLIENT_CREATE_ERROR = "CLIENT_CREATE_ERROR";
        public static String WORKER_CREATE_REQUEST = "WORKER_CREATE_REQUEST";
        public static String WORKER_CREATE_SUCCESS = "WORKER_CREATE_SUCCESS";
        public static String WORKER_CREATE_ERROR = "WORKER_CREATE_ERROR";
        public static String WORKER_STABLISH_PAYMENT_REQUEST = "WORKER_STABLISH_PAYMENT_REQUEST";
        public static String WORKER_STABLISH_PAYMENT_SUCCESS = "WORKER_STABLISH_PAYMENT_SUCCESS";
        public static String WORKER_STABLISH_PAYMENT_ERROR = "WORKER_STABLISH_PAYMENT_ERROR";
        public static String WORKER_STABLISH_PAYMENT_NOTALLOWED = "WORKER_STABLISH_PAYMENT_NOTALLOWED";
        public static String TICKET_CREATE_REQUEST = "TICKET_CREATE_REQUEST";
        public static String TICKET_CREATE_SUCCESS = "TICKET_CREATE_SUCCESS";
        public static String TICKET_CREATE_ERROR = "TICKET_CREATE_ERROR";
    }
}
