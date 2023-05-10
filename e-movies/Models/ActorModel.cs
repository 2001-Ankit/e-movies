using System.ComponentModel.DataAnnotations;

namespace e_movies.Models
{
    public class ActorModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProfileUrl { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Bio { get; set; }
        //Relatioship
        public List<Actor_MovieModel> Actor_movies { get; set; }

    }
}
