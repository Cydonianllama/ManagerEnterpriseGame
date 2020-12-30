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
        public List<Client> clients = new List<Client>() ;
        public List<Ticket> tickets = new List<Ticket>();

        private Store() { }

        public void addClientToStore(Client c)
        {
            clients.Add(c);
        }

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
