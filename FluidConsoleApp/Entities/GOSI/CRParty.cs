using System;

namespace FluidConsoleApp.Entities
{
    public class CRParty
    {
        public long PartyId { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }

        public RelationType RelationType { get; set; }
        public Nationality Nationality { get; set; }

    }
}