using System;
using System.Threading.Tasks.Sources;
using csharpHola.utils;
using csharpHola.entities;
using MySqlConnector;
using System.Collections.Generic;
using System.Security.Cryptography;

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
                String commandTest = "select * from clients c inner join informationperson i where c.idClient = i.idClient";
                MySqlConnection con = Connection.GetInstance().getConnection();
                con.Open();
                MySqlCommand response = new MySqlCommand(commandTest, con);
                MySqlDataReader readerData;
                readerData = response.ExecuteReader();
                while (readerData.Read())
                {
                    
                    Object idInfo = readerData.GetValue(1);
                    Object idClient = readerData.GetValue(2);
                    Object idWorker = readerData.GetValue(3);
                    Object fullname = readerData.GetValue(4);
                    Object birthdate = readerData.GetValue(5);
                    Object typeIdentification = readerData.GetValue(6);
                    Object codeIdentification = readerData.GetValue(7);
                    DateTime birthdate_ = DateTime.Parse(birthdate.ToString());


                    PersonInfo p = new PersonInfo(idInfo.ToString(), idClient.ToString(), idWorker.ToString(), fullname.ToString(), birthdate_, typeIdentification.ToString(), codeIdentification.ToString());
                    Client c = new Client(p, idClient.ToString());
                    Store.GetInstance().addClientToStore(c);
                    
                    Console.WriteLine(c.Info.Fullname);
                    //String codeClientAux = readerData.GetValue(0).ToString();
                    //Client auxClient = new Client(codeClientAux);
                    //Store.GetInstance().addClientToStore(auxClient);
                }
                con.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }

        public string createClient(PersonInfo p)
        {
            String idClient = "";
            MySqlConnection con = Connection.GetInstance().getConnection();
            //String QUERY = Queries.getIntance().QUERY_CREATE_CLIENT();
            string QUERY = "insert into clients() values() ;"+
                "insert into informationperson(idClient, idWorker, fullname, birthdate, typeIdentification, codeIdentification) "+
                "values((select idClient from clients order by idClient desc limit 1 ), null, " + "'"+ p.Fullname +"'" + ", '"+ p.Birthdate +"'" + " ,'"+ p.TypeIdentification+ "',"  + " '"+ p.CodeIdentification+ "'); ";
            con.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(QUERY, con);
                //command.Parameters.Add("@Fullname",MySqlDbType.VarChar);
                //command.Parameters.Add("@Bithday",MySqlDbType.Date);
                //command.Parameters[0].Value = fullname;
                //command.Parameters[1].Value = date;
                command.ExecuteNonQuery();

                //get the id of the current client created
                idClient = command.LastInsertedId.ToString();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            con.Close();
            return idClient;
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