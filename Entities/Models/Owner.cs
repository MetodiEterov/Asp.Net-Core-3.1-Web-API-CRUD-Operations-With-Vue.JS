using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    /// <summary>
    /// Owner class
    /// </summary>
    [Table("owner")]
    public class Owner
    {
        /// <summary>
        /// Id property
        /// </summary>
        [Column("OwnerId")]
        public Guid Id { get; set; }

        /// <summary>
        /// Name property
        /// </summary>
        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string Name { get; set; }

        /// <summary>
        /// DateOfBirth property
        /// </summary>
        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Address property
        /// </summary>
        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, ErrorMessage = "Address cannot be longer than 100 characters")]
        public string Address { get; set; }

        /// <summary>
        /// Accounts property
        /// </summary>
        public ICollection<Account> Accounts { get; set; }
    }
}
