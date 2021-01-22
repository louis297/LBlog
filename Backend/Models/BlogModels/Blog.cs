using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models.BlogModels
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        [Required]
        public string AuthorID { get; set; }
        [Required]
        public string AuthorName { get; set; }
        [Required]
        public string BlogTitle { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string BlogContent { get; set; }
        [Required]
        public DateTime CreateTime { get; set; }
        [Required]
        public DateTime ModifyTime { get; set; }
        [Required]
        public bool Active { get; set; }
        [Required]
        public BlogType Type { get; set; }
        public ICollection<BlogTag> Tags { get; set; }
        [Required]
        public bool StickTop { get; set; }
    }
}
