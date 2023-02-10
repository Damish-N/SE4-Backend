using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Employee.DataAccessLayer
{
    public class Coffee
    {
        [Key]
        public string Id { get; } = Guid.NewGuid().ToString();

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string Type { get; set; }

        public int Rating { get; set; }
    }
}
