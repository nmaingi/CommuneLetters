using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommuneLetters.Models
{
    //not functional until user data can be collected and stored//
    public class NewClient
    {
        public string Name { get; set; }
        public string Essay { get; set; }

        public NewClient(string name, string essay)
        {
            Name = name;
            Essay = essay;
        }

        public NewClient() { }
    }

}

