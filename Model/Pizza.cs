using System.Collections.Generic;
using System.Linq;

namespace BlazingPizza
{
    /// <summary>
    /// Represents a customized pizza as part of an order
    /// </summary>
    public class Pizza
    {
        public int PizzaId { get; set; }
    
        public string Name { get; set; }
    
        public string Description { get; set; }
    
        public decimal Price { get; set; }
    
        public bool Vegetarian { get; set; }
    
        public bool Vegan { get; set; }
    }
}
