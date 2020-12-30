using System;
using System.Collections.Generic;
using System.Text;
using csharpHola.entities;
using csharpHola.utils;
using csharpHola.models;

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
        public void CreateClient(
            String Id, 
            DateTime emission ,
            DateTime  expiration,
            String nameDocument,
            String fullname,
            String Code)
        {
            c = new Client(
                Id,
                emission,
                expiration,
                nameDocument,
                fullname,
                Code);

            Store.GetInstance().clients.Add(c);
            Store.GetInstance().clients.ForEach(e => Console.WriteLine(e.FullName));
        }
        public void CreateClient()
        {
            Console.WriteLine("Documents :");
            Console.WriteLine("----------");
            Console.WriteLine("code (generated-automatic)");
            Console.WriteLine("fullname :");
            String Fullname = Console.ReadLine();
            Console.WriteLine("BirthDate /y/m/d :");
            String DateBirthdate = Console.ReadLine();
            DateTime BirthDate = DateTime.Parse(DateBirthdate);
            c.EmissionDate = BirthDate;
            c.FullName = Fullname;
            ModelClient.GetInstance().createClient(c);
        }
        public void DeleteClient()
        {

        }
        public void GetAllClients()
        {

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
