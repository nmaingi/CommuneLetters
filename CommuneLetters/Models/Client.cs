using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CommuneLetters.Models
{
    
    public class Client
    {
        
        [Key]
        [Display(Name ="Client name")]
        [Required(ErrorMessage ="This Field is required")]
        public string Name { get; set; }

        [Required(ErrorMessage ="This Field is required")]
        [Display(Name ="Client essay")]
        public string Essay { get; set; }


    }

}

