using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunnersFilmMVC.Models
{
    public class Genre
    {
        public virtual int GenreId { get; set; }
        public virtual String genre { get; set; }
    }
}