using System;
using System.Collections.Generic;
using System.Text;

namespace csharpHola.entities
{
    public class Client 
    {
        private PersonInfo _info;
        private string _idClient;
        public PersonInfo Info
        {
            get => _info;
            set => _info = value;
        }
        public string IdClient
        {
            get => _idClient;
            set => _idClient = value;
        }
        public Client(PersonInfo info,string idClient)
        {
            this._info = info;
            this._idClient = idClient;
        }
        public Client()
        {

        }
    }
}
