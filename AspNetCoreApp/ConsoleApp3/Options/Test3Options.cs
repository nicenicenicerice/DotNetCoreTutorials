using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Options
{
    internal class Test3Options
    {
        [Required]
        public int Id { get; set; }

        [Range(1, 5, ErrorMessage = "The {0} is an invalid Num, valid range is between {1} and {2}")]
        public int Num { get; set; }

        [MaxLength(10)]
        public string Description { get; set; } = string.Empty;
    }
}
