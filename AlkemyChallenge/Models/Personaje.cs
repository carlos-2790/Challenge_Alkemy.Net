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
    public class Personaje
    {
              
        public int ID { get; set; }
        [Required(ErrorMessage = "Por favor Ingrese el Imagen... ")]
        [DisplayName("Imagen ")]
        public string ImagenNombre { get; set; }

        [Required(ErrorMessage = "Por favor Ingrese el Nombre... ")]
        [DisplayName("Nombre ")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Por favor Ingrese el Edad... ")]
        [DisplayName("Edad")]
        public string Edad { get; set; }

        [Required(ErrorMessage = "Por favor Ingrese el Peso... ")]
        [DisplayName("Peso")]
        public int Peso { get; set; }

        [Required(ErrorMessage = "Por favor Ingrese el Historia... ")]
        [DisplayName("Historia")]
        public string Historia { get; set; }

        public List<Pelicula> Peliculas { get; set; }

        [NotMapped]
        [DisplayName("Cargar Imagen")]
        public IFormFile ImagenFile { get; set; }



    }
}
