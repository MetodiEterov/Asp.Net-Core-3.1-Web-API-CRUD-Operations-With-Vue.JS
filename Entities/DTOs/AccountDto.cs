using System;

namespace Entities.DTOs
{
    /// <summary>
    /// AccountDto class
    /// </summary>
    public class AccountDto
    {
        /// <summary>
        /// Id property
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// DateCreated property
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// AccountType property
        /// </summary>
        public string AccountType { get; set; }
    }
}
