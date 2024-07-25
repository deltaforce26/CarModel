using System.ComponentModel.DataAnnotations;

namespace CarModel.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Year { get; set; }
    }
}
