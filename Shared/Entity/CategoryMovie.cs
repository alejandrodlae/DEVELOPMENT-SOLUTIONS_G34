namespace Sprint3.Shared.Entity
{
    public class CategoryMovie
    {
        public int MovieId{get;set;}
        public int CategoryId{get;set;}
        public Genre Genre {get;set;}
        public Movie Movie {get;set;}
    }
}