using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RunnersFilmMVC.Models
{
    public class Review
    {
        public virtual int ReviewId { get; set; }
        [Required(ErrorMessage = "Name Is Required")]
        [StringLength(50)]
        public virtual string Name { get; set; }
        [Required(ErrorMessage = "Comment Is Required")]
        [StringLength(200)]
        public virtual string Comment { get; set; }
    }
}