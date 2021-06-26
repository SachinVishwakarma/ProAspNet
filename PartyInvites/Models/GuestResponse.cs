using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        public string Name { get; set; }
        public string EmailID { get; set; }
        public string Mobile { get; set; }
        public bool? WillAttend { get; set; }
    }
}
