using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace knockoutApp2.ViewModels
{
    public class CartViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "cartItems")]
        public virtual ICollection<CartItemViewModel> CartItems { get; set; }

        
    }
}
