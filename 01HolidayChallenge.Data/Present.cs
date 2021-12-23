using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01HolidayChallenge.Data
{
    public class Present
    {
        public enum PresentType { BigBox, SmallBox, BigBag, SmallBag, Stocking, Unwrapped }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Wrapping { get; set; }

        [Required]
        public string Contains { get; set; }

        public List<string> Hints { get; set; }

        [Required]
        public int TimesShaken { get; set; }

        [Required]
        public bool IsWrapped { get; set; }

        [ForeignKey(nameof(Tree))]
        public int TreeId { get; set; }

        [Required]
        public virtual Tree Tree { get; set; }
    }
}
