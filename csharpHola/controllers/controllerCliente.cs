using System;
using System.Collections.Generic;
using System.Text;
using csharpHola.entities;
using csharpHola.utils;
using csharpHola.models;
using System.IO;

namespace csharpHola.controllers
{
    class RepoCliente
    {
        private static RepoCliente _repoClient;
        public static RepoCliente GetInstance(){
            if(_repoClient == null){
                _repoClient = new RepoCliente();
            }
            return _repoClient;
        }
    }

    class controllerCliente
    {
        Client c = null;

        private static controllerCliente cc;
        public static controllerCliente getInstance()
        {
            if (cc == null) 
            {
                cc = new controllerCliente();
            }
            return cc;
        }
        public void CreateClient()
        {
            Console.WriteLine("Documents :");
            Console.WriteLine("----------");
            Console.WriteLine("code (generated-automatic)");
            Console.WriteLine("fullname :");
            String fullname = Console.ReadLine();
            Console.WriteLine("BirthDate /y/m/d :");
            String birthdate_aux = Console.ReadLine();
            DateTime birthdate = new DateTime();
            try
            {
                birthdate = DateTime.Parse(birthdate_aux);
            }
            catch(Exception a)
            {
                Console.WriteLine(a);
                birthdate_aux = Console.ReadLine();
            }
            Console.WriteLine("type identification");
            String typeIdentification = Console.ReadLine();
            Console.WriteLine("code identification");
            String codeIdentification = Console.ReadLine();

            PersonInfo auxPersonInfo = new PersonInfo(
                fullname,
                birthdate,
                typeIdentification,
                codeIdentification);

            //insert into a database
            string idCurrentClient = ModelClient.GetInstance().createClient(auxPersonInfo);

            //store in the programm
            Store.GetInstance().addClientToStore(new Client(auxPersonInfo,idCurrentClient));
        }
        public void DeleteClient(Client c)
        {
  
        }
        public void GetAllClients()
        {
            ModelClient.GetInstance().getClients();
        }
        public void RequestClient()
        {

        }
        private controllerCliente()
        {
            // this is a singleton
        }
    }

}
