namespace Moment_03.Models{
    public class Book {
        //proppar:
       public int ID {get; set;}
       public string? Title {get; set;}
       public int? Year {get; set;}
       public string? Genre {get; set;}

       public int? AuthorID {get; set;}
       public Author? Author {get; set;}

    }
}