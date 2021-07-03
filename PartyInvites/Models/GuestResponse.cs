using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please enter your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter your Email id")]
        public string EmailID { get; set; }
        [Required(ErrorMessage ="Please enter your Mobile number")]
        public string Mobile { get; set; }
        [Required(ErrorMessage ="Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}
