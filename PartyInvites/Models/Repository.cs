using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class Repository
    {
        private static List<PartyInvites.Models.GuestResponse> responses = new List<GuestResponse>();

        public static void AddResponse(GuestResponse guestResponse)
        {
            responses.Add(guestResponse);
        }

        public static IEnumerable<GuestResponse> Responses = responses;
    }
}
