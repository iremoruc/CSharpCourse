using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AsynchronousUser : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public Guid AsyncId { get; set; }
        //public DateTime StartedDate { get; set; }
        //public DateTime FinishedDate { get; set; }
    }
}
