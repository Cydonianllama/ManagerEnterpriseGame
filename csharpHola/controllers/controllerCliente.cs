using System;
using System.Collections.Generic;
using System.Text;
using csharpHola.entities;
using csharpHola.utils;

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

        public void clearAuxClient(Cliente c){
            c = null;
        }
    
    }

    class controllerCliente
    {
        Cliente c = null;
        Trabajador t = null;

        public void CreateClient()
        {

            /*
            String ID,
            DateTime emission,
            DateTime expiration,
            String name,
            String fullname,
            String codeclient
             */

            Console.WriteLine("Hello, Im worked fine");
            DateTime emission = new DateTime(2020, 12, 26);
            DateTime expiration = new DateTime();

            c = new Cliente(
                "1111",
                emission,
                expiration,
                "DNI",
                "Alberto Fujimori",
                "5558846");

            Store.GetInstance().clients.Add(c);
            Console.WriteLine("Hello, Im worked fine");
            RepoCliente.GetInstance().clearAuxClient(c);

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
    }
}
