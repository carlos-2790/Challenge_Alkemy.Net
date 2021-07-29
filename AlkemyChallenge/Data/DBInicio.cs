using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlkemyChallenge.Models;

namespace AlkemyChallenge.Data
{
    public static class DBInicio
    {
        public static void Inicio(DbContextAlkemy context)
        {
            //context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            

           /* if (context.Personajes.Any())
            {
                return;
            }

            var personajes = new Personaje[]
            {
               new Personaje{Imagen="noImagen",Nombre="Mickey",Peso=10,Historia="ihdsfhbfhb",Edad="102"},
               new Personaje{Imagen="noImagen",Nombre="Pluto",Peso=25,Historia="ihdsfhbfhb",Edad="10"},
               new Personaje{Imagen="noImagen",Nombre="Donald",Peso=5,Historia="ihdsfhbfhb",Edad="52"},
               new Personaje{Imagen="noImagen",Nombre="Minnie",Peso=12,Historia="ihdsfhbfhb",Edad="12"}
            };
            foreach(Personaje p in personajes)
            {
                context.Personajes.Add(p);
            }
            context.SaveChanges();

            if (context.Generos.Any())
            {
                return;
            }

            var generos = new Genero[]
            {
                new Genero{GeneroID=1,Nombre="Aventuras",Imagen="noImagen",NombreImagen=""},
                new Genero{GeneroID=2,Nombre="Policiales",Imagen="noImagen"},
                new Genero{GeneroID=3,Nombre="Comedia",Imagen="noImagen"},
                new Genero{GeneroID=4,Nombre="Suspenso",Imagen="noImagen"}
            };
            foreach(Genero g in generos)
            {
                context.Generos.Add(g);
            }
            context.SaveChanges();

            if (context.Peliculas.Any())
            {
                return;
            }
            var peliculas = new Pelicula[]
            {
                new Pelicula{PeliculaID=5,Imagen="no", Titulo= "Mickey y sus Aventuras",Calificacion=10,FechaDeCreacion=DateTime.Parse("2021-05-05")},
                new Pelicula{PeliculaID=6,Imagen="no", Titulo= "Los 101 dalmatas",Calificacion=5,FechaDeCreacion=DateTime.Parse("2020-11-15")},
                new Pelicula{PeliculaID=7,Imagen="no", Titulo= "Luca",Calificacion=8,FechaDeCreacion=DateTime.Parse("2021-01-14")},
                new Pelicula{PeliculaID=8,Imagen="no", Titulo= "Tom y Jerry",Calificacion=4,FechaDeCreacion=DateTime.Parse("2021-03-18")},
            };
            foreach(Pelicula p in peliculas)
            {
                context.Peliculas.Add(p);
            }
            context.SaveChanges();


            if (context.Usuarios.Any())
            {
                return;
            }

            var usuarios = new Login[]
            {
                new Login{Nombre = "Juan",Pass="1234"},
                new Login{Nombre="Carlos",Pass="lala"}
            };
            foreach(Login l in usuarios)
            {
                context.Usuarios.Add(l);
            }
            context.SaveChanges();*/



        }
    }
}
