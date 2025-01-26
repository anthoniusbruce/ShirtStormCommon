using System.ComponentModel.DataAnnotations;

namespace ShirtStormCommon.Models
{
    public class Image
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public byte[]? Bytes { get; set; }
    }
}
