namespace Gurukula.System.API.Entities
{
    public class Adminstrator
    {
        public Adminstrator(int id, string firstName, string lastName, Organization organization)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Organization = organization;

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Organization Organization { get; set; }
    }
}