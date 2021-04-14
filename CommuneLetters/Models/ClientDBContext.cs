using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CommuneLetters.Models
{
    public class ClientDBContext : DbContext
    {
        public ClientDBContext(DbContextOptions<ClientDBContext> options) : base(options)
        {

        }

        public DbSet<Client> ClientInfo { get; set; }

    }
}