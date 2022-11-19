using OperatorOverloading_Indexer_Reflection.Models;
using OperatorOverloading_Indexer_Reflection.Services.Interface;


namespace OperatorOverloading_Indexer_Reflection.Services
{
    public class BookService : IBookService
    {
        public int GetCount(Predicate<Book> predicate)
        {
            var books = GetAll();
            return books.FindAll(predicate).Count();

        }





        private List<Book> GetAll()
        {

            List<Book> books = new List<Book>();
            Book book1 = new()
            {
                Name = "Iskandername",
                Author = "Nizami"
            };

            Book book2 = new()
            {
                Name = "Shikayetname",
                Author = "Fizuli"
            };

            Book book3 = new()
            {
                Name = "Khosrov ve Shirin",
                Author = "Nizami"
            };

            Book book4 = new()
            {
                Name = "Ferhad ve Shirin",
                Author = "Fizuli"
            };

            Book book5 = new()
            {
                Name = "Sevil",
                Author = "Jafar Jabbarli"
            };



            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
            books.Add(book5);

            return books;

        }



    }
}
