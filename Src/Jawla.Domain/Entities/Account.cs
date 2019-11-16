using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jawla.Domain.Entities
{
    [Table("Account")]
    public class Account
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }
        [Required]
        [StringLength(500)]
        public string Email { get; set; }
    }
}
