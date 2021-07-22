using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlkemyChallenge.Models
{
    public class Genero
    {
       /* private int generoID;
        private string nombre;
        private string imagen;*/

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GeneroID { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }

        public ICollection<Genero> Generos { get; set; }




       /* public Genero(string nombre, string imagen, int generoId)
        {
            this.nombre = nombre;
            this.imagen = imagen;
            this.generoID = generoId;
        }*/


    }
}
