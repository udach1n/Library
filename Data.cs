using UDachyn_Dyploma.Models;

namespace UDachyn_Dyploma
{
    public class Data
    {
        public static void CreateData(UdachynDyplomaContext db)
        {
            if (db.Books.Count() == 0)
            {

                Book book1 = new Book { Name = "King", Author = "Grek", Age = new DateOnly(1999, 02, 11), Genre = Genre.Mystery };
                Book book2 = new Book { Name = "Car", Author = "Nill", Age = new DateOnly(2006, 09, 21), Genre = Genre.Fantasy };
                Book book3 = new Book { Name = "Sun", Author = "Dan", Age = new DateOnly(1990, 07, 27), Genre = Genre.Thriller };
                Book book4 = new Book { Name = "Moon", Author = "Bob", Age = new DateOnly(1860, 02, 11), Genre = Genre.Fantasy };
                Book book5 = new Book { Name = "Bind", Author = "Julia", Age = new DateOnly(1973, 11, 08), Genre = Genre.Thriller };
                Book book6 = new Book { Name = "Boy", Author = "Nick", Age = new DateOnly(1992, 10, 11), Genre = Genre.Novel };
                Book book7 = new Book { Name = "Library", Author = "Gill", Age = new DateOnly(1990, 01, 03), Genre = Genre.Philosophy };
                Book book8 = new Book { Name = "Book1", Author = "Maria", Age = new DateOnly(2009, 05, 11), Genre = Genre.Fairy_tale };
                Book book9 = new Book { Name = "Analyzing", Author = "Anna", Age = new DateOnly(2011, 04, 08), Genre = Genre.Romance_novel };
                Book book10 = new Book { Name = "Soap", Author = "Willow", Age = new DateOnly(2005, 03, 25), Genre = Genre.Romance_novel };
                Book book11 = new Book { Name = "Orange", Author = "Rayn", Age = new DateOnly(2009, 07, 09), Genre = Genre.History };
                Book book12 = new Book { Name = "Book", Author = "Gin", Age = new DateOnly(1999, 02, 18), Genre = Genre.Fairy_tale };
                Book book13 = new Book { Name = "Arrow", Author = "Dali", Age = new DateOnly(2006, 08, 30), Genre = Genre.Humor };
                Book book14 = new Book { Name = "Kick", Author = "Wank", Age = new DateOnly(2009, 07, 11), Genre = Genre.Philosophy };
                Book book15 = new Book { Name = "Arthur", Author = "Andrew", Age = new DateOnly(1999, 02, 11), Genre = Genre.Science_fiction };
                db.Books.AddRange(book1, book2, book3, book4, book5, book6, book7, book8, book9, book10, book11, book12, book13, book14, book15);
                db.SaveChanges();

                Role adminRole = new Role { Id = 1, Name = "admin" };
                Role userRole = new Role { Id = 2, Name = "client" };
                db.Roles.AddRange(adminRole, userRole);
                db.SaveChanges();

                Account account1 = new Account { Login = "1111", Password = "1111", IdRole = 2 };
                Account account2 = new Account { Login = "2222", Password = "2222", IdRole = 2 };
                Account account3 = new Account { Login = "3333", Password = "3333", IdRole = 2 };
                Account account4 = new Account { Login = "4444", Password = "4444", IdRole = 2 };
                db.Accounts.AddRange(account1, account2, account3, account4);
                db.SaveChanges();

                User user1 = new User { FirstName = "User", LastName = "1", Age = 20, Adress = "Warsaw", IdAccount = 1 };
                User user2 = new User { FirstName = "User", LastName = "2", Age = 21, Adress = "Kyiv", IdAccount = 2 };
                User user3 = new User { FirstName = "User", LastName = "3", Age = 22, Adress = "Lviv", IdAccount = 3 };
                User user4 = new User { FirstName = "User", LastName = "4", Age = 23, Adress = "London", IdAccount = 4 };
                db.Users.AddRange(user1, user2, user3, user4);



                db.SaveChanges();
            }
        }
    }
}
