namespace _05.BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class BooksTotal
    {
        public static void Main()
        {
            var justLibrary = new Library();
            justLibrary.Name = "SomeLibrary";
            justLibrary.Books = new List<Book>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var bookData = Console.ReadLine()
                    .Split();

                var currentBook = new Book(bookData[0], 
                    bookData[1], 
                    bookData[2], 
                    DateTime.ParseExact( bookData[3], "dd.MM.yyyy",CultureInfo.InvariantCulture),
                    bookData[4],
                    double.Parse(bookData[5]));

                justLibrary.Books.Add(currentBook);
            }

            var authorWhitTotalAmount = new Dictionary<string, double>();

            foreach (var book in justLibrary.Books)
            {
                if (!authorWhitTotalAmount.ContainsKey(book.Author))
                {
                    authorWhitTotalAmount[book.Author] = 0;
                }

                var currentPrice = book.Price;

                authorWhitTotalAmount[book.Author] += currentPrice;
            }

            var orderedByAutorsAndByTotal = authorWhitTotalAmount
                .OrderBy(x => x.Key)
                .OrderByDescending(y => y.Value)
                .ToDictionary(p => p.Key, p => p.Value);

            foreach (var author in orderedByAutorsAndByTotal)
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
            }
        }
    }
}
