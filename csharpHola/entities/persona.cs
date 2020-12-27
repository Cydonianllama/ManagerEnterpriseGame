using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace csharpHola.entities
{
    class Payment
    {
        private Double _pay;
        public Double Pay
        {
            get => _pay;
            set => _pay = value;
        }
        public Payment(Double Pay)
        {
            this.Pay = Pay;
        }
    }
    class DocumentIdentification
    {
        private String _id;
        private DateTime _emissionDate;
        private DateTime _expirationDate;
        private String _nameDocument;

        public String Id
        {
            get => _id;
            set => _id = value;
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
        public String NameDocument
        {
            get => _nameDocument;
            set => _nameDocument = value;
        }
        public DocumentIdentification(String ID,DateTime emission,DateTime expiration,String name)
        {
            this.Id = ID;
            this.EmissionDate = emission;
            this.EmissionDate = expiration;
            this.NameDocument = name;
        }
    }
    class Persona : DocumentIdentification
    {
        private String _fullname;
        private DateTime _birthdate;
        
        public String FullName
        {
            get => _fullname;
            set => _fullname = value;
        }

        public Persona(
            String ID,
            DateTime emission,
            DateTime expiration,
            String name,
            String fullname) 
            : base(
                  ID ,
                  emission ,
                  expiration ,
                  name)
        {
            this.FullName = fullname;
        }
    }
    class Trabajador : Persona
    {
        private Payment _payWorker;
        private String _codeWorker;
        public String CodeWorker
        {
            get => _codeWorker;
            set => _codeWorker = value;
        }
        public Payment PayWorker
        {
            get => _payWorker;
            set => _payWorker = value;
        }
        public Trabajador(
            String ID,
            DateTime emission,
            DateTime expiration,
            String name ,
            String fullname,
            String codeWorker) : 
            base(
                ID ,
                emission,
                expiration,
                name,
                fullname
                )
        {
            this.CodeWorker = codeWorker;
        }
    }
    class Cliente : Persona
    {
        private String _codeClient;
        public String CodeClient
        {
            get => _codeClient;
            set => _codeClient = value;
        }
        public Cliente(
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
