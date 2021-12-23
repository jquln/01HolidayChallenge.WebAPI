using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01HolidayChallenge.Data
{
    public class Tree
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Description ="Tree Description")]
        public string Description { get; set; }
        public virtual List<Ornament> Ornaments { get; set; }
    }
}
