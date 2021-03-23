 using System.Collections.Generic;
 

namespace CommuneLetters.Models
{
    public static class Repository
    {
        private static readonly List<Adminstrator> allAdmins = new List<Adminstrator>();
        public static IEnumerable<Adminstrator> AllAdmins
        {
            get { return allAdmins; }
        }
        private static readonly List<Client> allClients = new List<Client>();
        public static IEnumerable<Client> AllClients
        {
            get { return allClients; }
        }
        public static void NewClient(Client client)
        {
            allClients.Add(client);
        }
        public static void Remove(Client client) 
        { 
            allClients.Remove(client); 
        }
        public static void AddAdmin(Adminstrator adminstrator)
        {
            allAdmins.Add(adminstrator);
        }
        public static void RemoveAdmin(Adminstrator adminstrator)
        {
            allAdmins.Remove(adminstrator);
        }
    }
}
 