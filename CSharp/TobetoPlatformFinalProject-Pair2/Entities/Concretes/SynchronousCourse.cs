using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class SynchronousCourse : Entity<Guid>
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string LiveSessionName { get; set; }   
        public string LiveSessionUrl { get; set; }
        public string VideoUrl { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime FinishedDate { get; set; }
        public bool IsJoined { get; set; }
    }
}
