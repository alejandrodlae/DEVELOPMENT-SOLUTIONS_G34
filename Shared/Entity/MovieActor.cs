namespace Sprint3.Shared.Entity
{
    public class MovieActor
    {
        public int ActorId {get;set;}
        public int MovieId {get;set;}
        public Actor Actor {get;set;}
        public Movie Movie {get;set;}
        public int OrderCredits {get;set;}
        public string character{get;set;}
    }
}
