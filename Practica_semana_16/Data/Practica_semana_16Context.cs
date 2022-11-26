using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Practica_semana_16.Models;

namespace Practica_semana_16.Data
{
    public class Practica_semana_16Context : DbContext
    {
        public Practica_semana_16Context (DbContextOptions<Practica_semana_16Context> options)
            : base(options)
        {
        }

        public DbSet<Practica_semana_16.Models.Movie> Movie { get; set; }
    }
}
