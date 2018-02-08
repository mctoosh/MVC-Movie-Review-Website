using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RunnersFilmMVC.Models
{
    //this class populates and adds data on to the databases using the models. 
    public class RunnerIni : DropCreateDatabaseIfModelChanges<RunnerContext>
    {
        protected override void Seed(RunnerContext context)
        {
            Genre Genre1 = new Genre();
            Genre1.GenreId = 1;
            Genre1.genre = "Drama";
            context.Genres.Add(Genre1);

            Genre Genre2 = new Genre();
            Genre2.GenreId = 2;
            Genre2.genre = "Horror";
            context.Genres.Add(Genre2);

            Genre Genre3 = new Genre();
            Genre3.GenreId = 3;
            Genre3.genre = "Action";
            context.Genres.Add(Genre3);

            Genre Genre4 = new Genre();
            Genre4.GenreId = 4;
            Genre4.genre = "Adventure";
            context.Genres.Add(Genre4);

            Genre Genre5 = new Genre();
            Genre5.GenreId = 5;
            Genre5.genre = "Sci-Fi";
            context.Genres.Add(Genre5);

            Genre Genre6 = new Genre();
            Genre6.GenreId = 6;
            Genre6.genre = "Thriller";
            context.Genres.Add(Genre6);

            Genre Genre7 = new Genre();
            Genre7.GenreId = 7;
            Genre7.genre = "Crime";
            context.Genres.Add(Genre7);

            Genre Genre8 = new Genre();
            Genre8.GenreId = 8;
            Genre8.genre = "Comedy";
            context.Genres.Add(Genre8);


            Actor Actor1 = new Actor();
            Actor1.ActorId = 1;
            Actor1.Name = "James Coolen";
            Actor1.Age = 25;
            Actor1.Description = "James was born in England, London in 1991.";
            Actor1.Gender = "Male";
            context.Actors.Add(Actor1);

            Actor Actor2 = new Actor();
            Actor2.ActorId = 2;
            Actor2.Name = "Mary Jasmine";
            Actor2.Age = 32;
            Actor2.Description = "Mary was born in England, London in 1983.";
            Actor2.Gender = "Female";
            context.Actors.Add(Actor2);

            Actor Actor3 = new Actor();
            Actor3.ActorId = 3;
            Actor3.Name = "Fallon Gray";
            Actor3.Age = 22;
            Actor3.Description = "Fallon was born in England, London in 1995.";
            Actor3.Gender = "Male";
            context.Actors.Add(Actor3);

            Actor Actor4 = new Actor();
            Actor4.ActorId = 4;
            Actor4.Name = "Kyle Mathew";
            Actor4.Age = 52;
            Actor4.Description = "Kyle was born in England, London in 1950.";
            Actor4.Gender = "Male";
            context.Actors.Add(Actor4);

            Actor Actor5 = new Actor();
            Actor5.ActorId = 5;
            Actor5.Name = "Lesa Frona";
            Actor5.Age = 37;
            Actor5.Description = "Lesa was born in England, London in 1980.";
            Actor5.Gender = "Male";
            context.Actors.Add(Actor5);

            Actor Actor6 = new Actor();
            Actor6.ActorId = 6;
            Actor6.Name = "Vela Son";
            Actor6.Age = 25;
            Actor6.Description = "Veka was born in England, London in 1990.";
            Actor6.Gender = "Male";
            context.Actors.Add(Actor6);

            Actor Actor7 = new Actor();
            Actor7.ActorId = 7;
            Actor7.Name = "Gary Lincon";
            Actor7.Age = 42;
            Actor7.Description = "Gary was born in England, London in 1990.";
            Actor7.Gender = "Male";
            context.Actors.Add(Actor7);

            Actor Actor8 = new Actor();
            Actor8.ActorId = 8;
            Actor8.Name = "Barry Lincon";
            Actor8.Age = 22;
            Actor8.Description = "Barry was born in England, London in 1990.";
            Actor8.Gender = "Male";
            context.Actors.Add(Actor8);

            Actor Actor9 = new Actor();
            Actor9.ActorId = 9;
            Actor9.Name = "Jane Lincon";
            Actor9.Age = 36;
            Actor9.Description = "Jane was born in England, London in 1990.";
            Actor9.Gender = "Female";
            context.Actors.Add(Actor9);

            Actor Actor10 = new Actor();
            Actor10.ActorId = 10;
            Actor10.Name = "Farrel Lincon";
            Actor10.Age = 26;
            Actor10.Description = "Farrel was born in England, London in 1990.";
            Actor10.Gender = "Male";
            context.Actors.Add(Actor10);

            Actor Actor11 = new Actor();
            Actor11.ActorId = 11;
            Actor11.Name = "Lonel Lincon";
            Actor11.Age = 46;
            Actor11.Description = "Lonel was born in England, London in 1990.";
            Actor11.Gender = "Male";
            context.Actors.Add(Actor11);


            Director Director1 = new Director();
            Director1.DirectorId = 1;
            Director1.Name = "Kyle Fellow";
            Director1.Age = 50;
            Director1.Description = "Kyle was born in Austrailia, Sydney in 1963.";
            Director1.Gender = "Male";
            context.Directors.Add(Director1);

            Director Director2 = new Director();
            Director2.DirectorId = 2;
            Director2.Name = "Elizabeth Farrow";
            Director2.Age = 43;
            Director2.Description = "Elizabeth was born in Austrailia, Sydney in 1963.";
            Director2.Gender = "Female";
            context.Directors.Add(Director2);

            Director Director3 = new Director();
            Director3.DirectorId = 3;
            Director3.Name = "Hannah Selon";
            Director3.Age = 42;
            Director3.Description = "Hannah was born in Austrailia, Sydney in 1963.";
            Director3.Gender = "Female";
            context.Directors.Add(Director3);

            Director Director4 = new Director();
            Director4.DirectorId = 4;
            Director4.Name = "Knowel famel";
            Director4.Age = 34;
            Director4.Description = "Knowel was born in Austrailia, Sydney in 1963.";
            Director4.Gender = "Male";
            context.Directors.Add(Director4);

            Director Director5 = new Director();
            Director5.DirectorId = 5;
            Director5.Name = "John Friel";
            Director5.Age = 24;
            Director5.Description = "John was born in Austrailia, Sydney in 1963.";
            Director5.Gender = "Male";
            context.Directors.Add(Director5);

            Director Director6 = new Director();
            Director6.DirectorId = 6;
            Director6.Name = "Conner Jofery";
            Director6.Age = 39;
            Director6.Description = "Conner was born in Austrailia, Sydney in 1963.";
            Director6.Gender = "Male";
            context.Directors.Add(Director6);

            Director Director7 = new Director();
            Director7.DirectorId = 7;
            Director7.Name = "Harry Jofery";
            Director7.Age = 29;
            Director7.Description = "Harry was born in Austrailia, Sydney in 1963.";
            Director7.Gender = "Male";
            context.Directors.Add(Director7);

            Director Director8 = new Director();
            Director8.DirectorId = 8;
            Director8.Name = "Sydney Jofery";
            Director8.Age = 29;
            Director8.Description = "Sydney was born in Austrailia, Sydney in 1963.";
            Director8.Gender = "Female";
            context.Directors.Add(Director8);

            Director Director9 = new Director();
            Director9.DirectorId = 9;
            Director9.Name = "Karen Stephens";
            Director9.Age = 27;
            Director9.Description = "Karen was born in Austrailia, Sydney in 1988.";
            Director9.Gender = "Female";
            context.Directors.Add(Director9);

            Director Director10 = new Director();
            Director10.DirectorId = 10;
            Director10.Name = "Jill Thomas";
            Director10.Age = 45;
            Director10.Description = "Jill was born in Manchester, England in 1972.";
            Director10.Gender = "Female";
            context.Directors.Add(Director10);


            Director Director11 = new Director();
            Director11.DirectorId = 11;
            Director11.Name = "Thomas Gray";
            Director11.Age = 22;
            Director11.Description = "Thomas was born in London, England in 1990.";
            Director11.Gender = "Male";
            context.Directors.Add(Director11);

            Film Film1 = new Film();
            Film1.FilmId = 1;
            Film1.Movie = "Moonlight";
            Film1.Duration = "1h 30m";
            Film1.Description = "Movie was made in 2017.";
            Film1.Rating = 8;
            Film1.Year = 2017;
            Film1.Genre = Genre1;
            Film1.Actor = Actor1;
            Film1.Director = Director1;
            context.Films.Add(Film1);

            Film Film2 = new Film();
            Film2.FilmId = 2;
            Film2.Movie = "Summer";
            Film2.Duration = "3h 30m";
            Film2.Description = "Movie was made in 2012.";
            Film2.Rating = 4;
            Film2.Year = 2012;
            Film2.Genre = Genre2;
            Film2.Actor = Actor2;
            Film2.Director = Director2;
            context.Films.Add(Film2);

            Film Film3 = new Film();
            Film3.FilmId = 3;
            Film3.Movie = "Knight";
            Film3.Duration = "2h 30m";
            Film3.Description = "Movie was made in 2013.";
            Film3.Rating = 7;
            Film3.Year = 2013;
            Film3.Genre = Genre3;
            Film3.Actor = Actor3;
            Film3.Director = Director3;
            context.Films.Add(Film3);

            Film Film4 = new Film();
            Film4.FilmId = 4;
            Film4.Movie = "Harry Potter";
            Film4.Duration = "2h 30m";
            Film4.Description = "Movie was made in 2001.";
            Film4.Rating = 9;
            Film4.Year = 2001;
            Film4.Genre = Genre4;
            Film4.Actor = Actor4;
            Film4.Director = Director4;
            context.Films.Add(Film4);

            Film Film5 = new Film();
            Film5.FilmId = 5;
            Film5.Movie = "Need For Speed";
            Film5.Duration = "2h 30m";
            Film5.Description = "Movie was made in 2006.";
            Film5.Rating = 7;
            Film5.Year = 2006;
            Film5.Genre = Genre5;
            Film5.Actor = Actor5;
            Film5.Director = Director5;
            context.Films.Add(Film5);

            Film Film6 = new Film();
            Film6.FilmId = 6;
            Film6.Movie = "Good Will Hunting";
            Film6.Duration = "2h 30m";
            Film6.Description = "Movie was made in 1997.";
            Film6.Rating = 10;
            Film6.Year = 1997;
            Film6.Genre = Genre6;
            Film6.Actor = Actor6;
            Film6.Director = Director6;
            context.Films.Add(Film6);

            Film Film7 = new Film();
            Film7.FilmId = 7;
            Film7.Movie = "The Witch Hunt";
            Film7.Duration = "1h 30m";
            Film7.Description = "Movie was made in 2003.";
            Film7.Rating = 10;
            Film7.Year = 2003;
            Film7.Genre = Genre6;
            Film7.Actor = Actor7;
            Film7.Director = Director7;
            context.Films.Add(Film7);

            Film Film8 = new Film();
            Film8.FilmId = 8;
            Film8.Movie = "The Haunted House";
            Film8.Duration = "3h 30m";
            Film8.Description = "Movie was made in 2016.";
            Film8.Rating = 5;
            Film8.Year = 2016;
            Film8.Genre = Genre2;
            Film8.Actor = Actor8;
            Film8.Director = Director8;
            context.Films.Add(Film8);

            Film Film9 = new Film();
            Film9.FilmId = 9;
            Film9.Movie = "The GodFather";
            Film9.Duration = "1h 30m";
            Film9.Description = "Movie was made in 2014.";
            Film9.Rating = 5;
            Film9.Year = 2016;
            Film9.Genre = Genre7;
            Film9.Actor = Actor9;
            Film9.Director = Director9;
            context.Films.Add(Film9);

            Film Film10 = new Film();
            Film10.FilmId = 10;
            Film10.Movie = "Power Rangers";
            Film10.Duration = "1h 30m";
            Film10.Description = "Movie was made in 2017.";
            Film10.Rating = 7;
            Film10.Year = 2017;
            Film10.Genre = Genre3;
            Film10.Actor = Actor10;
            Film10.Director = Director10;
            context.Films.Add(Film10);

            Film Film11 = new Film();
            Film11.FilmId = 11;
            Film11.Movie = "DeadPool";
            Film11.Duration = "1h 30m";
            Film11.Description = "Movie was made in 2016.";
            Film11.Rating = 9;
            Film11.Year = 2016;
            Film11.Genre = Genre3;
            Film11.Actor = Actor11;
            Film11.Director = Director11;
            context.Films.Add(Film11);


            Review Review1 = new Review();
            Review1.ReviewId = 1;
            Review1.Name = "Good Will Hunting";
            Review1.Comment = "Good Will Hunting was a great movie to watch";

            Review Review2 = new Review();
            Review2.ReviewId = 2;
            Review2.Name = "John Friel";
            Review2.Comment = "John Friel is a great actor to watch, I enjoyed all his movies. ";

            Review Review3 = new Review();
            Review3.ReviewId = 3;
            Review3.Name = "Kyle Fellow";
            Review3.Comment = "Kyle Fellow is a great Director, I enjoyed all his movies. ";


            base.Seed(context);
        }
    }
}