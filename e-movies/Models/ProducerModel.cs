using System.ComponentModel.DataAnnotations;

namespace e_movies.Models
{
    public class ProducerModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProfileUrl { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Bio { get; set; }

        //Relationship
        public List<MovieModel> Movies { get; set; }    
    }
}
