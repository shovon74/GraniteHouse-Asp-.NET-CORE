using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraniteHouse.Models.ViewModel
{
    public class ShoppingCartViewModel
    {
        internal List<Products> products;

        public List<Products> Products { get; set; }
        public Appointments Appointments { get; set; }
    }
}
