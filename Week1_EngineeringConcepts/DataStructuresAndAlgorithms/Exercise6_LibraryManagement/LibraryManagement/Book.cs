namespace LibraryManagement
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public Book(int bookId, string title, string author)
        {
            BookId = bookId;
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"ID: {BookId}, Title: {Title}, Author: {Author}";
        }
    }
}