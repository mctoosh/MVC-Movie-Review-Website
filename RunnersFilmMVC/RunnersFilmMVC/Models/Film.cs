using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RunnersFilmMVC.Models
{
    public class Film
    {
        public virtual int FilmId { get; set; }
        [Required(ErrorMessage = "Movie Is Required")]
        [StringLength(50)]
        public virtual string Movie { get; set; }
        [Required(ErrorMessage = "Year Is Required")]
        public virtual int Year { get; set; }
        [Required(ErrorMessage = "Description Is Required")]
        [StringLength(200)]
        public virtual string Description { get; set; }
        [Required(ErrorMessage = "Duration Is Required")]
        [StringLength(20)]
        public virtual string Duration { get; set; }
        [Required(ErrorMessage = "Rating Is Required")]

        public virtual int Rating { get; set; }
        
        public virtual int GenreId { get; set; }
        

        public virtual Genre Genre { get; set; }
        
        public virtual int ActorId { get; set; }
        

        public virtual Actor Actor { get; set; }

        public virtual int DirectorId { get; set; }
        

        public virtual Director Director { get; set; }
    }
}