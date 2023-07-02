using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string field { get; set; }
        public int age { get; set; }
        
        public Blog blog { get; set; }


    }
}
