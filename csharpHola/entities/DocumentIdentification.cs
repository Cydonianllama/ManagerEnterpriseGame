using System;
using System.Collections.Generic;
using System.Text;

namespace csharpHola.entities
{
    public class DocumentIdentification
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
        public DocumentIdentification(String ID, DateTime emission, DateTime expiration, String name)
        {
            this.Id = ID;
            this.EmissionDate = emission;
            this.EmissionDate = expiration;
            this.NameDocument = name;
        }
        public DocumentIdentification() { }
    }
}
