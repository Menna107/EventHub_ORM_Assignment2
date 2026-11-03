using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ORM_Assignment2.Models
{
    internal class Attendee
    {
        public int AttendeeId { get; set; }

        [MaxLength(150)]
        [Required]
        public string FullName { get; set; }

        [Required]
        [MaxLength(200)]
        public string Email { get; set; }

        [Required]
        [MaxLength(150)]
        public string Street { get; set; }

        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        [MaxLength(100)]
        public string Country { get; set; }

        [MaxLength(20)]
        [Required]
        [Column("ZipCode")]
        public string PostalCode{ get; set; }

        [NotMapped]
        public string FullAddress
        {
            get
            {
                return $"{Street}, {City}, {Country}, {PostalCode}";
            }
        }
    }
}
