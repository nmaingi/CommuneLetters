using System;
using System.ComponentModel.DataAnnotations;

namespace CommuneLetters.Models
{
    //not functional until user data can be collected and stored//
    public class Client
    {
        [Key]
        public string Name { get; set; }
        public Client(string name)
        {
            Name = name;
        }
        
        public string Essay { get; set; }


    }

}

