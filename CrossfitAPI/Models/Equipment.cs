using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrossfitAPI.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}
