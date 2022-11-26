using Microsoft.EntityFrameworkCore;
using Practica_semana_16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_semana_16.Data
{
    public class Semana16_Context : DbContext
    {
        public Semana16_Context(DbContextOptions<Semana16_Context> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Teather> Teather { get; set; }
    }
}
