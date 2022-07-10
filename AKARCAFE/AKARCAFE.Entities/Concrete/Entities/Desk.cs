using AKARCAFE.Core.Entities;
using System;

namespace AKARCAFE.Entities.Concrete.Entities
{
    public class Desk : IEntity
    {
        public int Id { get; set; }
        public string DeskName { get; set; }
        public bool Status { get; set; }
        public bool ReservationStatus { get; set; }
        public string Description{ get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateTime { get; set; }


    }
}
