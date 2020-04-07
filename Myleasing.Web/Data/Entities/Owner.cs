using Myleasing.Web.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Myleasing.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

       public User User { get; set; }

        public ICollection<Property> Propeties { get; set; }

        public ICollection<Contract> Contracts { get; set; }
    }
}
