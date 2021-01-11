using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace csharpHola.entities
{
    public class PersonInfo
    {
        private string _idInfo;
        private string _idClient;
        private string _idWorker;
        private string _fullname;
        private DateTime _birthdate;
        private string _typeIdentification;
        private string _codeIdentification;
        public string IdInfo
        {
            get => _idInfo;
            set => _idInfo = value;
        }
        public string Iclient
        {
            get => _idClient;
            set => _idClient = value;
        }
        public string IdWorker
        {
            get => _idWorker;
            set => _idWorker = value;
        }
        public string Fullname
        {
            get => _fullname;
            set => _fullname = value;
        }
        public DateTime Birthdate
        {
            get => _birthdate;
            set => _birthdate = value;
        }
        public string TypeIdentification
        {
            get => _typeIdentification;
            set => _typeIdentification = value;
        }
        public string CodeIdentification
        {
            get => _codeIdentification;
            set => _codeIdentification = value;
        }

        public PersonInfo(
            string idInfo, 
            string idClient , 
            string idWorker , 
            string fullname , 
            DateTime birthdate , 
            string typeIdentification , 
            string codeIdentification)
        {
            this._idInfo = idInfo;
            this._idClient = idClient;
            this._idWorker = idWorker;
            this._fullname = fullname;
            this._birthdate = birthdate;
            this._typeIdentification = typeIdentification;
            this._codeIdentification = codeIdentification;
        }
        public PersonInfo(
            string fullname,
            DateTime birthdate,
            string typeIdentification,
            string codeIdentification
            )
        {
            this._fullname = fullname;
            this._birthdate = birthdate;
            this._typeIdentification = typeIdentification;
            this._codeIdentification = codeIdentification;
        }
    }
}
