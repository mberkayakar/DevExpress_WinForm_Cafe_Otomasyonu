using AKARCAFE.Core.Entities;
using AKARCAFE.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;

namespace AKARCAFE.Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }

        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public List<string>  ProductImage { get; set; }
        public int Stock { get; set; }
        public Decimal Money { get; set; }

        public Menu MenuId { get; set; }


    }
}
