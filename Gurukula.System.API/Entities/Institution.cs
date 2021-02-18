namespace Gurukula.System.API.Entities
{
    public class Institution
    {
        public Institution(int id, string name, string location, string code)
        {
            this.Id = id;
            this.Name = name;
            this.Location = location;
            this.Code = code;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Code { get; set; }
    }
}