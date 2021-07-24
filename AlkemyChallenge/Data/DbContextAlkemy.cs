using AlkemyChallenge.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlkemyChallenge.Data
{
    public class DbContextAlkemy : DbContext
    {
        public DbContextAlkemy(DbContextOptions<DbContextAlkemy> options) : base(options)
        { }

        public DbSet<Personaje> Personajes { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Login> Usuarios { get; set; }
        
        //public DbSet<AlkemyChallenge.Models.Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personaje>().ToTable("Personaje");
            modelBuilder.Entity<Genero>().ToTable("Genero");
            modelBuilder.Entity<Pelicula>().ToTable("Pelicula");
            modelBuilder.Entity<Login>().ToTable("Usuario");
            
        }


        

    }
}
