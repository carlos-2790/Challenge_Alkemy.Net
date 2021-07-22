using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace AlkemyChallenge.Models
{
    public class Personaje
    {
       /* private int id;
        private string imagen;
        private string nombre;
        private string edad;
        private int peso;
        private string historia;*/

        
        public int ID { get; set; }
        public string Imagen { get; set; }
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public int Peso { get; set; }
        public string Historia { get; set; }

        public ICollection<Personaje> Personajes { get; set; }




       /* public Personaje(int id,string imagen, string nombre, string edad, int peso, string historia)
        {
            this.id = id;
            this.imagen = imagen;
            this.nombre = nombre;
            this.edad = edad;
            this.peso = peso;
            this.historia = historia;
            
        }*/



    }
}
