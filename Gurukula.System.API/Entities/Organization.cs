using System.Collections.Generic;

namespace Gurukula.System.API.Entities
{
    public class Organization
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public string Code {get;set;}
        public List<Institution> InstitutionList {get;set;}
    }
}