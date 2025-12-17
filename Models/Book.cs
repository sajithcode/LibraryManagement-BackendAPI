namespace LibraryManagement_BackendAPI.Models
{
    public class Book
    {
        public int BookID {  get; set; }
        public string Title {  get; set; } = string.Empty;
        public string Author {  get; set; } = string.Empty;
        public string? Description { get; set; }

    }
}
