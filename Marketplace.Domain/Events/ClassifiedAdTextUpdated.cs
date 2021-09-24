using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Domain.Events
{
    public class ClassifiedAdTextUpdated
    {
        public Guid Id { get; set; }
        public string AdText { get; set; }
    }
}
