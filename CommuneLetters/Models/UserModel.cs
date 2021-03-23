using System;

namespace CommuneLetters.Models
{
    //not functional until user data can be collected and stored//
    public class Client
    {
        public string Name { get; set; }
        public Client(string name)
        {
            Name = name;
        }
        
        public string Essay { get; set; }

        public override string ToString()
        {
            return Name;
        }


    }

}

