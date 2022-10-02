
using v39tors;

Author author = new("J.R.R. Tolkien");
author.PublishedBooks.Add(new Book("The return of the king", Generes.Fantasy, author, 2005));
author.PublishedBooks.Add(new Book("The fellowship of the ring", Generes.Fantasy, author, 2001));
author.PublishedBooks.Add(new Book("The two towers", Generes.Fantasy, author, 2003));

author.PublishedBooks.Sort();

foreach (Book book in author.PublishedBooks)
{
    Console.WriteLine(book);
}