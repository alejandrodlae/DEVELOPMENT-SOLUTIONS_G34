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
        public string Image{get;set;}
        public string Genre{get;set;}
        public string Synopsis{get;set;}
        public string Raiting {get;set;}
        public DateTime MovieReleaseDate {get;set;}
       

    }
}