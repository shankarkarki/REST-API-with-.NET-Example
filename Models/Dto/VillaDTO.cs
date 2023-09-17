using System.ComponentModel.DataAnnotations;

namespace Models.DTO
{
    public class VillaDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string? Name { get; set; }
        public int Occupany { get; set; }
        public int Sqft { get; set; }
        public string? ImageUrl { get; set; }
        public string? Amenity { get; set; }
        public string? Details { get; set; }
        public double Rate { get; set; }

    }
}