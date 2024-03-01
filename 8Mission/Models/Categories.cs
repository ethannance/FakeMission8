using System.ComponentModel.DataAnnotations;

namespace _8Mission.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}

