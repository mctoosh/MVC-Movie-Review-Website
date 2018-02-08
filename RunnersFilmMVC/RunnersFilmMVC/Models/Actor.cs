using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RunnersFilmMVC.Models
{
    public class Actor
    {
        public virtual int ActorId { get; set; }
        [Required(ErrorMessage = "Name Is Required")]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required(ErrorMessage = "Gender Is Required")]
        [StringLength(30)]
        public virtual string Gender { get; set; }
        public virtual int Age { get; set; }
        [Required(ErrorMessage = "Description Is Required")]
        [StringLength(200)]
        public virtual string Description { get; set; }
        public virtual ICollection<Film> Films { get; set; }
    }
}