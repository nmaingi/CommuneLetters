using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CommuneLetters.Models
{
    
    public class Client
    {
        
        [Key]
        [Display(Name ="Client name")]
        public string Name { get; set; }

        
        [Display(Name ="Client essay")]
        public string Essay { get; set; }


    }

}

