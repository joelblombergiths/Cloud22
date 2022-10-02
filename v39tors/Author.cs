namespace v39tors
{
    internal class Author
    {
        public string Name { get;  }
        public BookCase PublishedBooks { get; }

        public Author(string name)
        {
            Name = name;
            PublishedBooks = new();
        }
    }
}
