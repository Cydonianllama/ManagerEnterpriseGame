using System;
using System.Collections.Generic;
using System.Text;
using csharpHola.entities;

namespace csharpHola.utils
{
    class Store
    {
        private static Store _store;

        //this is the store of my app
        public List<Trabajador> workers = new List<Trabajador>();
        public List<Cliente> clients = new List<Cliente>() ;
        public List<Ticket> tickets = new List<Ticket>();

        private Store() { }
        public static Store GetInstance()
        {
            if(_store == null)
            {
                _store = new Store();
            }
            return _store;
        }
    }
}
