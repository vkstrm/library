namespace Library.Models 
{
    public class Author 
    {
        public string FirstName { get; set; }

        public string LastName { get; set;}

        public string toString() 
        {
            return LastName + ", " + FirstName;
        }
    }
}