using e_movies.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_movies.Models
{
    public class MovieModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string ImageUrl { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }
        //Relationship
        public List<Actor_MovieModel> Actor_movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public CinemaModel Cinema { get; set; }


        //Producer

        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public ProducerModel Producer { get; set; }

    }
}
