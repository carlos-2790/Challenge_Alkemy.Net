using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace AlkemyChallenge.Models
{
    public class Personaje
    {
              
        public int ID { get; set; }
        public string Imagen { get; set; }
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public int Peso { get; set; }
        public string Historia { get; set; }

        public ICollection<Personaje> Personajes { get; set; }
        
       

     

    }
}
