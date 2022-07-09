using AKARCAFE.Core.Entities;
using System.Collections.Generic;

namespace AKARCAFE.Entities.Concrete.Entities
{
    public class Menu : IEntity
    {
        public int Id { get; set; }
        public string MenuName { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }



    }
}
