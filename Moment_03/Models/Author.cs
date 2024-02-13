namespace Moment_03.Models
{
    public class Author
    {
        //proppar:
        public int ID { get; set; }
        public string? Name { get; set; }

        public List<Book>? Books {get; set;}

    }
}