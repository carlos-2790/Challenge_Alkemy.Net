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
    public class Genero
    {
             
        
        [ForeignKey("ID")]
        public int GeneroID { get; set; }

        [Required(ErrorMessage = "Por favor Ingrese el Nombre... ")]
        [DisplayName("Nombre ")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Por favor Ingrese el Nombre... ")]
        [DisplayName("Nombre Imagen")]
        public string NombreImagen { get; set; }

        public List<Pelicula> Peliculas { get; set; }

        [NotMapped]
        [DisplayName ("Cargar Imagen")]
        public IFormFile ImagenFile { get; set; }
              

    }
}
