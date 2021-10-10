using System;
using Sprint3.Shared.Entity;
using System.Collections.Generic;

namespace Sprint3.Client.Services
{
    public class ServiceMovie: IServiceMovie 
    {
        public List<Movie>GetMovies(){
            return new List<Movie>(){
                new Movie(){MovieName="Jungle Cruise", Image="Images/Movies/Movie1.jpg", Genre="Genero: Aventura/Acción", Synopsis="trama", Raiting = "Calificación: 4.5", MovieReleaseDate=new DateTime(2021,09,26)},
                new Movie(){MovieName="Spiderman", Image="Images/Movies/Movie2.jpg", Genre="Genero: Acción ", Synopsis="trama", Raiting = "Calificación: 4.5", MovieReleaseDate=new DateTime(2021,09,26)},
                new Movie(){MovieName="Rapidos y furiosos 9", Image="Images/Movies/Movie3.jpg", Genre="Genero: Acción ", Synopsis="trama", Raiting = "Calificación: 4.5", MovieReleaseDate=new DateTime(2021,09,26)},
                new Movie(){MovieName="Vanguard ", Image="Images/Movies/Movie4.jpg", Genre="Genero: Acción ", Synopsis="trama", Raiting = "Calificación: 4.5", MovieReleaseDate=new DateTime(2021,09,26)},
                new Movie(){MovieName="Free Guy", Image="Images/Movies/Movie5.jpg", Genre="Genero: Comedia ", Synopsis="trama", Raiting = "Calificación: 4.5", MovieReleaseDate=new DateTime(2021,09,26)},
                new Movie(){MovieName="Duro de cuidar 2", Image="Images/Movies/Movie6.jpg", Genre="Genero: Acción/comedia ", Synopsis="trama", Raiting = "Calificación: 4.5", MovieReleaseDate=new DateTime(2021,09,26)},
                new Movie(){MovieName="Son como niños 2", Image="Images/Movies/Movie7.jpg", Genre="Genero: Comedia", Synopsis="trama", Raiting = "Calificación: 4.5", MovieReleaseDate=new DateTime(2021,09,26)},
                new Movie(){MovieName="Atentado en el estadio", Image="Images/Movies/Movie8.jpg", Genre="Genero: Acción", Synopsis="trama", Raiting = "Calificación: 4.5", MovieReleaseDate=new DateTime(2021,09,26)},
                new Movie(){MovieName="Bad voys for life", Image="Images/Movies/Movie9.jpg", Genre="Genero: Acción ", Synopsis="trama", Raiting = "Calificación: 4.5", MovieReleaseDate=new DateTime(2021,09,26)},
                new Movie(){MovieName="Origen", Image="Images/Movies/Movie10.jpg", Genre="Genero: Suspenso", Synopsis="trama", Raiting = "Calificación: 4.5", MovieReleaseDate=new DateTime(2021,09,26)},
                new Movie(){MovieName="Coco", Image="Images/Movies/Movie11.jpg", Genre="Genero: Animada ", Synopsis="trama", Raiting = "Calificación: 4.5", MovieReleaseDate=new DateTime(2021,09,26)},
                new Movie(){MovieName="Raya", Image="Images/Movies/Movie12.jpg", Genre="Genero: Animada ", Synopsis="trama", Raiting = "Calificación: 4.5", MovieReleaseDate=new DateTime(2021,09,26)},

            };
        }
    }
}