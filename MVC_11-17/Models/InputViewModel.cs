using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_11_17.Models
{
    public class InputViewModel
    {

        public int q { set; get; }
        public int skaic { set; get; }
        [Required]
        [StringLength(50,MinimumLength =7)]
        public string name { set; get; }



        public string surname { set; get; }

        
        



    }
}
