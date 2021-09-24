using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Domain.Events
{
    public class ClassifiedAdCreated
    {
        public Guid Id { get; set; }
        public Guid OwnerId { get; set; }
    }
}
