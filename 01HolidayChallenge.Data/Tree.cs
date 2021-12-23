using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01HolidayChallenge.Data
{
    public class Tree
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual List<Ornament> Ornaments { get; set; }
    }
}
