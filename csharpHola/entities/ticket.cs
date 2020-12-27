using System;
using System.Collections.Generic;
using System.Text;

namespace csharpHola.entities
{
    class Ticket
    {
        private String _ticketCode;
        private DateTime _dateEmission;
        private String _currentWorkerCode;
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
        public String ClientCurrentWorkerCode
        {
            get => _currentWorkerCode;
            set => _currentWorkerCode = value;
        }
        public String ClientCode
        {
            get => _clientCode;
            set => _clientCode = value;
        }

        public Ticket(
            String ticketCode,
            DateTime dateEmission,
            String currentworkercode,
            String clientCode
            ) 
        {
            this.TicketCode = ticketCode;
            this.DateEmission = dateEmission;
            this.ClientCurrentWorkerCode = currentworkercode;
            this.ClientCode = clientCode;
        }
    }
}
