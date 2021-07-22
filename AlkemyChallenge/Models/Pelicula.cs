using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlkemyChallenge.Models
{
    public class Pelicula
    {
      /*  public int peliculaID;
        public string imagen;
        public string titulo;
        public DateTime fechaDeCreacion;
        public int calificacion;*/


        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PeliculaID { get; set; }
        public string Imagen { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public int Calificacion { get; set; }

        public ICollection<Pelicula> Peliculas { get; set; }



      /*  public Pelicula(string imagen, string titulo, DateTime fechaDeCreacion, int calificacion, int peliculaID)
        {
            this.imagen = imagen;
            this.titulo = titulo;
            this.fechaDeCreacion = fechaDeCreacion;
            this.calificacion = calificacion;
            this.peliculaID = peliculaID;
        }*/


    }
}
