using System.ComponentModel.DataAnnotations;

namespace e_movies.Models
{
    public class CinemaModel
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        //Relationship
        public List<MovieModel> Movies { get; set; }
    }
}
