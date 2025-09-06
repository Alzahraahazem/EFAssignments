using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Data.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public int TopicId { get; set; }
        public string Name { get; set; }
        public TimeOnly Duration { get; set; }
        public string Description { get; set; }

    }
}
