using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlkemyChallenge.Models
{
    public class Genero
    {
       

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("ID")]
        public int GeneroID { get; set; }
        public string Nombre { get; set; }
        //public string Imagen { get; set; }
        [DisplayName("Nombre Imagen")]
        public string NombreImagen { get; set; }

        [NotMapped]
        [DisplayName ("Cargar Imagen")]
        public IFormFile ImagenFile { get; set; }
        //public ICollection<Genero> Generos { get; set; }




       /* public Genero(string nombre, string imagen, int generoId)
        {
            this.nombre = nombre;
            this.imagen = imagen;
            this.generoID = generoId;
        }*/


    }
}
