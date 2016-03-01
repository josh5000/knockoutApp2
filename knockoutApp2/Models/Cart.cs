using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace knockoutApp2.Models
{
    public class Cart
    {
        public int Id { get; set; }
        [Index(IsUnique =true)]
        [StringLength(255)]
        public string SessionId { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
