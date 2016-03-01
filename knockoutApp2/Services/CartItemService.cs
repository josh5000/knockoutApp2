using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using knockoutApp2.DAL;
using knockoutApp2.Models;
using System.Data.Entity;

namespace knockoutApp2.Services
{
    public class CartItemService : IDisposable
    {
        private knockoutApp2Context _db = new knockoutApp2Context();

        public CartItem GetByCartIdAndBookId(int cartId, int bookId)
        {
            return _db.CartItems.SingleOrDefault(ci => ci.CartId == cartId && ci.BookId == bookId);
        }
        
        public CartItem AddToCart(CartItem cartItem)
        {
            var existingCartItem = GetByCartIdAndBookId(cartItem.CartId, cartItem.BookId);

            if (null == existingCartItem)
            {
                _db.Entry(cartItem).State = EntityState.Added;
                existingCartItem = cartItem;
            }
            else
            {
                existingCartItem.Quantity += cartItem.Quantity;
            }

            _db.SaveChanges();

            return existingCartItem;
        }

        public void UpdateCartItem(CartItem cartItem)
        {
            _db.Entry(cartItem).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void DeleteCartItem(CartItem cartItem)
        {
            _db.Entry(cartItem).State = EntityState.Deleted;
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
            //throw new NotImplementedException();
        }
    }
}
