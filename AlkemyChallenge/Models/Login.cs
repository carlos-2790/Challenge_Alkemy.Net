using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlkemyChallenge.Models
{
    public class Login
    {
        
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Pass { get; set; }



       
       


    }
}
