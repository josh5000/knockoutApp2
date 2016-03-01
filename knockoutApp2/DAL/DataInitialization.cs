using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using knockoutApp2.Models;

namespace knockoutApp2.DAL
{
    //public class DataInitialization : DropCreateDatabaseIfModelChanges<knockoutApp2Context>
     public class DataInitialization : DropCreateDatabaseAlways<knockoutApp2Context>


    {
        protected override void Seed(knockoutApp2Context context)
        {
            //base.Seed(context);

            var categories = new List<Category>
            {
                new Category {Name = "Technology" },
                new Category {Name = "Science Fiction" },
                new Category {Name = "Non Fiction" },
                new Category {Name = "Graphic Novels" }

            };

            categories.ForEach(c => context.Categories.Add(c));

            var author = new Author
            {
                Biography = "...",
                FirstName = "Jamie",
                LastName = "Munro"

            };

            var books = new List<Book>
            {
                new Book
                {
                    Author = author,
                    Category = categories[0],
                    Description = "Web Development with KnockoutJS",
                    Featured = true,
                    ImageUrl = "http://ecx.images-amazon.com/images/I/51T%20BWt430bL._AA160_.jpg",
                    Isbn = "1491914319",
                    ListPrice = 19.99m,
                    SalePrice = 17.99m,
                    Synopsis = "Not Available",
                    Title = "KnockoutJS: Building Dynamic Client-Side Web Applications"

                },
                new Book
                {
                    Author =author,
                    Category = categories[0],
                    Description = "Cross Mobile Platform Development with PhoneGap vNext",
                    Featured = true,
                    ImageUrl ="http://ecx.images-amazon.com/images/I/51AkFkNeUxL._AA160_.jpg",
                    Isbn = "1449319548",
                    ListPrice = 14.99m,
                    SalePrice = 13.99m,
                    Synopsis = "Not Available",
                    Title = "20 Recipes for Programming PhoneGap"
                },
                new Book
                {
                    Author =author,
                    Category = categories[0],
                    Description = "Faster Web Development with MVC 3",
                    Featured = true,
                    ImageUrl = "http://ecx.images-amazon.com/images/I/51LpqnDq8-L._AA160_.jpg",
                    Isbn ="1449309860",
                    ListPrice = 19.99m,
                    SalePrice = 16.99m,
                    Synopsis = "Not Available",
                    Title = "20 Recipes for Programming MVC 3: Faster, Smarter Web Development"

                },
                new Book
                {
                    Author = author,
                    Category = categories[0],
                    Description = "CakePHP and R.A.D",
                    Featured = true,
                    ImageUrl = "http://ecx.images-amazon.com/images/I/41JC54HEroL._AA160_.jpg",
                    Isbn = "1460954394",
                    ListPrice = 14.99m,
                    SalePrice = 13.49m,
                    Synopsis = "Extreme Rapid Application Development: 0 to Deploy in 10 Days with PHP",
                    Title = "Rapid Application Development with CakePHP"
                }
            };

            books.ForEach(b => context.Books.Add(b));
            //books.ForEach(b => context.Books.Remove(b));

            context.SaveChanges();


        }
    }
}




