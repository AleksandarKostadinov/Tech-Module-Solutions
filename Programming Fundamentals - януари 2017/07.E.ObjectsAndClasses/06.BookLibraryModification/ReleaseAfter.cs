namespace _06.BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class ReleaseAfter
    {
        static void Main()
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
                    DateTime.ParseExact(bookData[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    bookData[4],
                    double.Parse(bookData[5]));

                justLibrary.Books.Add(currentBook);
            }

            var releasedAfter = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in justLibrary.Books.Where(b => b.ReleaseDate > releasedAfter).OrderBy(x => x.Title).OrderBy(y => y.ReleaseDate))
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
            }
        }
    }
}
