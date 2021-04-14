using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace CommuneLetters.Models
{
    public class AdminDBContext: DbContext
    {
        public AdminDBContext(DbContextOptions<AdminDBContext> options) : base(options)
        {

        }


        public DbSet<Adminstrator> AdminInfo { get; set; }


    }

}
