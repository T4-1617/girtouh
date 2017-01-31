using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebÖvn_221116.Models
{
    public class GuestResponse
    {
        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage ="Ange ditt mobilnummer")]
        public string Phone { get; set; }
    }
}