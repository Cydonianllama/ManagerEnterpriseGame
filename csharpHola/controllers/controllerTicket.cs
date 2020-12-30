using System;
using System.Collections.Generic;
using System.Text;
using csharpHola.entities;
using csharpHola.utils;

namespace csharpHola.controllers
{
  
    class ControllerTicket
    {
        public void CreateTicket(
            String ticketcode ,
            DateTime emission , 
            String clientcode)
        {
            Ticket auxTicket = new Ticket(ticketcode, emission, clientcode);
            Store.GetInstance().tickets.Add(auxTicket);
        }
        public void DestroyTicket(
            String clientCode
            )
        {
            //Store.GetInstance().tickets.ForEach( p => p.ClientCode = "hola" );
            List<Ticket> ticket_ = Store.GetInstance().tickets;
            foreach(Ticket t in ticket_)
            {
                if(t.ClientCode == clientCode)
                {
                    Store.GetInstance().tickets.Remove(t);
                }
            }
        }
        
        public void getStateTicket()
        {

        }

        public ControllerTicket() { }
    }
}
