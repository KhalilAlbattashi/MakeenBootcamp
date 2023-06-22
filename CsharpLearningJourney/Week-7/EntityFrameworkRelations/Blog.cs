using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore
{
    public class Blog
    {
        public int id { get; set; }
        public string? BlogTitle { get; set; }
        
        [Required]
        public string BlogDescription { get; set;}

        // to make relations inside the database you need to create inctance of the table inside the class
        // for one relation and a list<classname> for many relation
        public List<Post> posts{ get; set;}
    }
}
