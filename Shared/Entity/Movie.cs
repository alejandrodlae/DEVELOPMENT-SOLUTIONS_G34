using System.Collections.Generic;
using System.Security.Cryptography;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System;
using System.ComponentModel.DataAnnotations;
namespace Sprint3.Shared.Entity
{
    public class Movie
    {
        
        public int Id {get;set;}
        [Required (ErrorMessage = "El campo {0} es requerido")]
        public string MovieName {get;set;}
        [Required (ErrorMessage = "El campo {0} es requerido")]
        public string Image{get;set;}
        [Required (ErrorMessage = "El campo {0} es requerido")]
        public string Genre{get;set;}
        [Required (ErrorMessage = "El campo {0} es requerido")]
        public string Synopsis{get;set;}
        [Required (ErrorMessage = "El campo {0} es requerido")]
        public string Raiting {get;set;}
        [Required (ErrorMessage = "El campo {0} es requerido")]
        public DateTime MovieReleaseDate {get;set;}
        public List <CategoryMovie> CategoriesMovie {get;set;} = new List <CategoryMovie> ();
        public List <MovieActor> MovieActor {get;set;}
        
       

    }
}