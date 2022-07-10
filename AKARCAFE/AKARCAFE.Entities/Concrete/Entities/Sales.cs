using AKARCAFE.Core.Entities;
using System;

namespace AKARCAFE.Entities.Concrete.Entities
{
    public class Sales : IEntity
    {
        public int Id { get; set; }
        public string SalesCode { get; set; }
        public decimal Amount { get; set; }
        public decimal Paid { get; set; }
        public decimal RemainingAmount { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }


    }
}
