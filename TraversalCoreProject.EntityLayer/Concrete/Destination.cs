using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalCoreProject.EntityLayer.Concrete
{
    public class Destination
    {
        public int Id { get; set; }
        public string City { get; set; } = null!;
        public string DayNight { get; set; } = null!;
        public double Price { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Capacity { get; set; }
        public bool Status { get; set; }
    }
}
