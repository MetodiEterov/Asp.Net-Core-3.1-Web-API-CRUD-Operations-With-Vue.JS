using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    /// <summary>
    /// Account class
    /// </summary>
    [Table("account")]
    public class Account
    {
        /// <summary>
        /// Id property
        /// </summary>
        [Column("AccountId")]
        public Guid Id { get; set; }

        /// <summary>
        /// DateCreated property
        /// </summary>
        [Required(ErrorMessage = "Date created is required")]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// AccountType property
        /// </summary>
        [Required(ErrorMessage = "Account type is required")]
        public string AccountType { get; set; }

        /// <summary>
        /// OwnerId property
        /// </summary>
        [ForeignKey(nameof(Owner))]
        public Guid OwnerId { get; set; }

        /// <summary>
        /// Owner property
        /// </summary>
        public Owner Owner { get; set; }
    }
}
