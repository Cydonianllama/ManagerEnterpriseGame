using System;
using System.Collections.Generic;
using System.Text;

namespace csharpHola.models
{
    class Modeltickets
    {

        private static Modeltickets Model;
        public static Modeltickets getInstance()
        {
            if (Model == null)
            {
                Model = new Modeltickets();
            }
            return Model;
        }

        public void getTickets()
        {

        }

        public void createTicket()
        {

        }

        public void deleteTicket()
        {

        }

        public Modeltickets()
        {

        }
    }
}
