using AKARCAFE.Core.Entities;
using System;

namespace AKARCAFE.Entities.Concrete.Entities
{
    public class SalesHistory : IEntity
    {
        public int Id { get; set; }
        public string SalesCode { get; set; }
        public string SalesType { get; set; }
        public decimal Money { get; set; }
        public DateTime Date { get; set; }


    }
}
