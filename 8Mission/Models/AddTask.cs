using _8Mission.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _8Mission.Models
{
    public class AddTask
    {
        [Key]
        [Required]
        public int TaskId { get; set; }

        [Required(ErrorMessage = "Task Name is required")]
        public string TaskName { get; set; }

        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "Quadrant is required")]
        public int Quadrant { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Categories? Category { get; set; }

        public bool? Completed { get; set; }
    }
}
