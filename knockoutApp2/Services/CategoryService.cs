using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using knockoutApp2.DAL;
using knockoutApp2.Models;

namespace knockoutApp2.Services
{
    public class CategoryService : IDisposable
    {
        private knockoutApp2Context _db = new knockoutApp2Context();

        public List<Category> Get()
        {
            return _db.Categories.OrderBy(c => c.Name).ToList();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        
    }
}
