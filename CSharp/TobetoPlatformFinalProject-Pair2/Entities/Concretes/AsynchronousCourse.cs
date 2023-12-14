using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AsynchronousCourse : Entity<Guid>
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string VideoUrl { get; set; }
        
    }
}
