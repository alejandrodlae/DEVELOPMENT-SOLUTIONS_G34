using System.Net.Mime;
using System.Security.AccessControl;
using Sprint3.Shared.Entity;
using System.Collections.Generic;
using System;

namespace Sprint3.Client.Services
{
    public class ServiceActor: IServiceActor
    {
        public List<Actor>GetActors(){
            return new List<Actor>(){
            new Actor(){ActorName = "Dwayne Johnson", Image="Images/Actors/Actor1.jpg", Gender =Gender.Masculino, Nationality = "Colombiano", Biography= "biografia", DateOfBirth=new DateTime(1950,12,03)},
            new Actor(){ActorName = "Dave Bautista", Image="Images/Actors/Actor2.jpg", Gender =Gender.Masculino, Nationality = "Colombiano", Biography= "biografia", DateOfBirth=new DateTime(1950,12,03)},
            new Actor(){ActorName = "Emily Blunt", Image="Images/Actors/Actor3.jpg", Gender =Gender.Masculino, Nationality = "Colombiano", Biography= "biografia", DateOfBirth=new DateTime(1950,12,03)},
            new Actor(){ActorName = "Vanessa Kirby", Image="Images/Actors/Actor4.jpg", Gender =Gender.Masculino, Nationality = "Colombiano", Biography= "biografia", DateOfBirth=new DateTime(1950,12,03)},
            new Actor(){ActorName = "kevin hart", Image="Images/Actors/Actor5.jpg", Gender =Gender.Masculino, Nationality = "Colombiano", Biography= "biografia", DateOfBirth=new DateTime(1950,12,03)},
            new Actor(){ActorName = "Jackie Chan", Image="Images/Actors/Actor6.jpg", Gender =Gender.Masculino, Nationality = "Colombiano", Biography= "biografia", DateOfBirth=new DateTime(1950,12,03)},
            new Actor(){ActorName = "Leonardo DiCaprio", Image="Images/Actors/Actor7.jpg", Gender =Gender.Masculino, Nationality = "Colombiano", Biography= "biografia", DateOfBirth=new DateTime(1950,12,03)},
            new Actor(){ActorName = "Nathalie Emmanuel", Image="Images/Actors/Actor8.jpg", Gender =Gender.Masculino, Nationality = "Colombiano", Biography= "biografia", DateOfBirth=new DateTime(1950,12,03)},
            new Actor(){ActorName = "Jordana Brewster", Image="Images/Actors/Actor9.jpg", Gender =Gender.Masculino, Nationality = "Colombiano", Biography= "biografia", DateOfBirth=new DateTime(1950,12,03)},
            
        };
      }
    }
}