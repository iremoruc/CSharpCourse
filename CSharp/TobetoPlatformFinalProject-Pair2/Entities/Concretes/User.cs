using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class User : Entity<Guid>
    {
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        //public string RepeatedPassword { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string About { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string AddressDescription { get; set; }

    }
}
