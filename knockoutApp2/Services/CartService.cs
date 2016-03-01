using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using knockoutApp2.DAL;
using System.Data.Entity;
using knockoutApp2.Models;

namespace knockoutApp2.Services
{
    public class CartService : IDisposable
    {
        private knockoutApp2Context _db = new knockoutApp2Context();

        public Cart GetBySessionId(string sessionId)
        {
            var cart = _db.Carts.Include("CartItems").Where(c => c.SessionId == sessionId).SingleOrDefault();

            cart = CreateCartIfItDoesntExist(sessionId, cart);

            return cart;
        }

        private Cart CreateCartIfItDoesntExist(string sessionId, Cart cart)
        {
            if (null == cart)
            {
                cart = new Cart
                {
                    SessionId = sessionId,
                    CartItems = new List<CartItem>()
                };
                _db.Carts.Add(cart);
                _db.SaveChanges();
            }
            return cart;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
            _db.Dispose();
        }
    }
}
