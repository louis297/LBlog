using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models.BlogModels
{
    public class BlogTag
    {
        [Key]
        public int TagID { get; set; }
        [Required]
        [MaxLength(50)]
        public string TagName { get; set; }
        public string TagDescription { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
