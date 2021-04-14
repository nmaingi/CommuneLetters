using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CommuneLetters.Models

{
    public class Adminstrator
    {
        [Key]

        public string Name { get; set; }

        [Required(ErrorMessage ="Enter Username: ")]
        [Display(Name ="Username: ")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Enter Password: ")]
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        public string Password { get; set; }

    }


}
