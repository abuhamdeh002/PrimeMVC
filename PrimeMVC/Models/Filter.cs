namespace PrimeMVC.Models
{
    public class Filter : Book
    {
        public string BookID { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public string PublicationYear { get; set; }
    }
}
