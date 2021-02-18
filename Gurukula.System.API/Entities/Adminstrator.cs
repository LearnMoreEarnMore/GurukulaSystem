namespace Gurukula.System.API.Entities
{
    public class Adminstrator
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName {get;set;}
        public string Code {get;set;}
        public Organization Organization {get;set;}
    }
}