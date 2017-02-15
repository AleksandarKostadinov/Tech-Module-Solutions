namespace _9.BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    class AuthorsPricesSumFiles
    {
        public static void Main()
        {
            var justLibrary = new Library();
            justLibrary.Name = "SomeLibrary";
            justLibrary.Books = new List<Book>();

            var libraryInfo = File.ReadAllLines("input.txt");

            for (int i = 0; i < libraryInfo.Length; i++)
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
                .OrderByDescending(y => y.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(p => p.Key, p => p.Value);

            var output = new List<string>();

            foreach (var author in orderedByAutorsAndByTotal)
            {
                output.Add($"{author.Key} -> {author.Value:f2}");
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}
