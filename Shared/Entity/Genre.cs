using System;
using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;

namespace Sprint3.Shared.Entity
{
    public class Genre
    {
       public int Id {get;set;}
       [Required(ErrorMessage = "El campo {0} es requerido")]
       public string Name{get;set;}
    }

    
}