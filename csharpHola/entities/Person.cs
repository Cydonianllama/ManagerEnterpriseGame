using System;
using System.Collections.Generic;
using System.Text;

namespace csharpHola.entities
{
    public class Person : DocumentIdentification
    {
        private String _fullname;
        private DateTime _birthdate;

        public String FullName
        {
            get => _fullname;
            set => _fullname = value;
        }
        public DateTime Birthday
        {
            get => _birthdate;
            set => _birthdate = value;
        }
        public Person(String fullname , DateTime birthday)
        {
            this._fullname = fullname;
            this._birthdate = birthday;
        }
        public Person(
            String ID,
            DateTime emission,
            DateTime expiration,
            String name,
            String fullname)
            : base(
                  ID,
                  emission,
                  expiration,
                  name)
        {
            this.FullName = fullname;
        }
        public Person() { }
    }
}
