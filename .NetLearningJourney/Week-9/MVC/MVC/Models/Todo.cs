using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Todo
    {
        public int id { get; set; }
        [MaxLength(50)]
        public string description { get; set; }
    }
}
