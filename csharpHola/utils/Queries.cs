using System;
using System.Collections.Generic;
using System.Text;

namespace csharpHola.utils
{
    public class Queries
    {

        private static Queries q;

        public String QUERY_GET_CLIENTS()
        {
            const String FINAL_QUERY = "SELECT * FROM clients limit 5";
            return FINAL_QUERY;
        }

        public String QUERY_CREATE_CLIENT()
        {
            //String QUERY = "INSERT INTO person(FullName,Bithday) values(@FullName,@Bithday)";
            String QUERY = "INSERT INTO clients() values();";
            return QUERY;
        }
        public String QUERY_UPDATE_CLIENT()
        {
            return "no implementado";
        }

        public String QUERY_DELETE_CLIENT()
        {
            return "no implementado";
        }

        public static Queries getIntance()
        {
            if (q == null)
            {
                q = new Queries();
            }
            return q;
        }
        private Queries() { }
    }
}
