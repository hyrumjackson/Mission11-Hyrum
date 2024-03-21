namespace Mission11_Hyrum.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
