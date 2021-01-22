using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models.BlogModels
{
    public class BlogType
    {
        [Key]
        public int BlogTypeID { get; set; }
        [Required]
        public string BlogTypeName { get; set; }
    }
}
