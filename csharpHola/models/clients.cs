using System;
using System.Threading.Tasks.Sources;
using csharpHola.utils;
using csharpHola.entities;
using MySqlConnector;
using System.Collections.Generic;

namespace csharpHola.models
{
    public class ModelClient
    {
        private static ModelClient mc;
        private Client C;

        public static  ModelClient GetInstance()
        {
            if (mc == null)
            {
                mc = new ModelClient();
            }
            return mc;
        }

        public void getClients()
        {
            try
            {
                C = new Client();
                String commandTest = "SELECT * FROM clients LIMIT 10";
                MySqlConnection con = Connection.GetInstance().getConnection();
                con.Open();
                MySqlCommand response = new MySqlCommand(commandTest, con);
                MySqlDataReader readerData;
                readerData = response.ExecuteReader();
                while (readerData.Read())
                {
                    Console.WriteLine(readerData.GetValue(0));
                    Console.WriteLine(readerData.GetValue(1));
                    String codeClientAux = readerData.GetValue(0).ToString();
                    Client auxClient = new Client(codeClientAux);
                    Store.GetInstance().addClientToStore(auxClient);
                }
                con.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }

        public void createClient(Client client)
        {
            String Fullname = client.FullName;
            String BirthDate  = 
            Queries.getIntance().QUERY_CREATE_CLIENT("Erick manuel grandez mendoza","12/2/5");
        }
        public void DeleteClient()
        {
           

        }

        public void UpdateClient()
        {

        }

        private ModelClient()
        {

        }
    }
}