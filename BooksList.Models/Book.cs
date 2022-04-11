namespace BooksList.Models
{
    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}