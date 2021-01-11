using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace csharpHola.entities
{
    public class Ticket
    {
        private string _idTicket;
        private string _idClient;
        private DateTime _emissionDate;
        private DateTime _expirationDate;

        public string IdTicket
        {
            get => _idTicket;
            set => _idTicket = value;
        }
        public string IdClient
        {
            get => _idClient;
            set => _idClient = value;
        }
        public DateTime EmissionDate
        {
            get => _emissionDate;
            set => _emissionDate = value;
        }
        public DateTime ExpirationDate
        {
            get => _expirationDate;
            set => _expirationDate = value;
        }

        public Ticket(
            string idTicket,
            string idClient,
            DateTime emissionDate,
            DateTime expirationDate)
        {
            this._idClient = idClient;
            this._idTicket = idTicket;
            this._emissionDate = emissionDate;
            this._expirationDate = expirationDate;
        }
        public Ticket()
        {

        }

    }

}
