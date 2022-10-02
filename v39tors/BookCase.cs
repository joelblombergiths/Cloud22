using System.Collections;
using System.Collections.Generic;

namespace v39tors
{
    internal class BookCase : IEnumerable, IEnumerator
    {
        private readonly List<Book> _books;
        private int _current = -1;

        public BookCase()
        {
            _books = new();
        }

        public void Sort()
        {
            _books.Sort();
        }

        public void Add(Book book) => _books.Add(book);
        
        object IEnumerator.Current => _books[_current];

        public bool MoveNext() => _current++ < _books.Count - 1;

        public void Reset() => _current = -1;        
                
        public IEnumerator GetEnumerator() => this;        
        public void Dispose() { }
    }
}
