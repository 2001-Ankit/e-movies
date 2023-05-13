using System.ComponentModel.DataAnnotations;

namespace e_movies.Models
{
    public class ActorModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture Url")]
        public string ProfileUrl { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Bio")]
        public string Bio { get; set; }
        //Relatioship
        public List<Actor_MovieModel> Actor_movies { get; set; }

    }
}
