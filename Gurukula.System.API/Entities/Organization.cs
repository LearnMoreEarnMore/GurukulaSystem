using System.Collections.Generic;

namespace Gurukula.System.API.Entities
{
    public class Organization
    {
        public int OrganizationId {get;set;}
        public string OrganizationName {get;set;}

        public List<Institution> InstitutionList {get;set;}
    }
}