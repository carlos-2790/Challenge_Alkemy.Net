using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlkemyChallenge.Models
{
    public class Pelicula
    {
        [ForeignKey("ID" + "GeneroID")]
        public int PeliculaID { get; set; }
               
        [Required(ErrorMessage = "Por favor Ingrese el nombre de la Imagen... ")]
        [DisplayName("Nombre de Imagen")]
        public string ImagenNombre { get; set; }

        [Required(ErrorMessage = "Por favor Ingrese el Titulo... ")]
        [DisplayName("Titulo")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Por favor Ingrese la Fecha... ")]
        [DisplayName("Fecha Estreno")]
        public DateTime FechaDeCreacion { get; set; }
        public int Calificacion { get; set; }

        [NotMapped]
        [DisplayName("Cargar Imagen")]
        public IFormFile ImagenFile { get; set; }

       



    }
}
