using AKARCAFE.Core.Entities;
using System;

namespace AKARCAFE.Entities.Concrete.Entities
{
    public class DeskEvent : IEntity
    {
        public int Id { get; set; }
        public string SalesCode { get; set; }
        public int DeskId { get; set; }
        public int Quantity { get; set; }
        public int QuantityPrice { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }






    }
}
