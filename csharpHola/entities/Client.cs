using System;
using System.Collections.Generic;
using System.Text;

namespace csharpHola.entities
{
    public class Client : Person
    {
        private String _codeClient;
        public String CodeClient
        {
            get => _codeClient;
            set => _codeClient = value;
        }
        public Client(String _codeClient)
        {
            this.CodeClient = _codeClient;
        }
        public Client(String fullName, DateTime birthday) : base(
                 fullName,
                 birthday
                 )
        {

        }
        public Client()
        {

        }
        public Client(
            String ID,
            DateTime emission,
            DateTime expiration,
            String name,
            String fullname,
            String codeclient) :
        base(
            ID,
            emission,
            expiration,
            name,
            fullname
            )
        {
            this.CodeClient = codeclient;
        }
    }
}
