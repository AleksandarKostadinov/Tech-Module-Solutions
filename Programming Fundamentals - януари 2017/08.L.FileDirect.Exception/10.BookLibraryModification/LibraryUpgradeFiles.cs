namespace _10.BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    class LibraryUpgradeFiles
    {
        static void Main()
        {
            var justLibrary = new Library();
            justLibrary.Name = "SomeLibrary";
            justLibrary.Books = new List<Book>();

            var libraryInfo = File.ReadAllLines("input.txt");

            for (int i = 0; i < libraryInfo.Length - 1; i++)
            {
                var bookData = libraryInfo[i]
                    .Split();

                var currentBook = new Book(bookData[0],
                    bookData[1],
                    bookData[2],
                    DateTime.ParseExact(bookData[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    bookData[4],
                    double.Parse(bookData[5]));

                justLibrary.Books.Add(currentBook);
            }

            var releasedAfter = DateTime.ParseExact(libraryInfo[libraryInfo.Length - 1], "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var output = new List<string>();

            foreach (var book in justLibrary.Books.Where(b => b.ReleaseDate > releasedAfter).OrderBy(y => y.ReleaseDate).ThenBy(x => x.Title))
            {
                output.Add($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}
