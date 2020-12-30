using System;
using System.Collections.Generic;
using System.Text;

namespace csharpHola.entities
{
    public class Ticket
    {
        private String _ticketCode;
        private DateTime _dateEmission;
        private String _clientCode;

        public String TicketCode
        {
            get => _ticketCode;
            set => _ticketCode = value;
        }
        public DateTime DateEmission
        {
            get => _dateEmission;
            set => _dateEmission = value;
        }
        public String ClientCode
        {
            get => _clientCode;
            set => _clientCode = value;
        }

        public Ticket(
            String ticketCode,
            DateTime dateEmission,
            String clientCode
            ) 
        {
            this.TicketCode = ticketCode;
            this.DateEmission = dateEmission;
            this.ClientCode = clientCode;
        }
    }
}
