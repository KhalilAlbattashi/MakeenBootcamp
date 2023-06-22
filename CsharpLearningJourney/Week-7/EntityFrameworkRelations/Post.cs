using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore
{
    public class Post
    {
        public int PostId { get; set; }
        [Required]
        public string PostTitle { get; set; }
        [Required]
        public string PostDescription { get; set; }
        public string? PostTag { get; set; }
        public List<Blog> PostPlogs{ get; set; }  
    }
}
