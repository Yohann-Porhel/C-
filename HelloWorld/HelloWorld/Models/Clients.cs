using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class Clients
    {
        public List<Client> ObtenirListeClients()
        {
            return new List<Client>
            {
                new Client {Age=33, Nom="Yohann" },
                new Client {Age=18, Nom="Delphine" },
                new Client {Age=45, Nom="Cathy" },
                new Client {Age=98, Nom="Robert" },
            };
        }
    }
}