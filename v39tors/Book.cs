namespace v39tors
{
    public enum Generes
    {
        ScienceFicton,
        Fantasy,
        Horror,
        Detective
    }

    internal class Book : IComparable<Book>
    {
        public string Title { get; }
        public Generes Genere { get; }
        public Author Author { get; }
        public int PublishedYear { get; }

        public Book(string title,Generes genere, Author author, int publishedYear)
        {
            Title = title;
            Genere = genere;
            Author = author;
            PublishedYear = publishedYear;
        }

        public override string ToString() => Title;

        public int CompareTo(Book? book) => PublishedYear.CompareTo(book?.PublishedYear);
        
    }
}
