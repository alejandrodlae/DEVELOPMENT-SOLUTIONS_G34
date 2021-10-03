using System;
namespace Sprint3.Shared.Entity
{
    public class Actor
    {
        public int Id {get;set;}
        public string ActorName{get;set;}
        public string Image{get;set;}
        public Gender Gender{get;set;}
        public string Nationality{get;set;}
        public string Biography{get;set;}
        public DateTime DateOfBirth {get;set;}
    }

    public enum Gender{
        Femenino = 0,
        Masculino =1
    }
}