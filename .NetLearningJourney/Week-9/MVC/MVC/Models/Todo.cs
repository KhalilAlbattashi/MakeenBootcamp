using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Todo
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Description is Requirde")]
        public string? description { get; set; }
    }
}
