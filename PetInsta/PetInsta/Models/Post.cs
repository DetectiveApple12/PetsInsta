namespace PetInsta.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public int Pet { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string ImageUrl { get; set; }
        public string Contents { get; set; }
        public int Likes { get; set; }
    }
}
