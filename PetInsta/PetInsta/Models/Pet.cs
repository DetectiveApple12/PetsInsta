namespace PetInsta.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProfilePhotoUrl { get; set;}
        public string Comments { get; set; }
        public int Likes { get; set; }
    }
}
