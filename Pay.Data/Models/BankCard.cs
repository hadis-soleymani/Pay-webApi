﻿using System.ComponentModel.DataAnnotations;

namespace Pay.Data.Models
{
    public class BankCard : BaseEntity<string>
    {
        public BankCard()
        {
            Id = Guid.NewGuid().ToString();
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
        [Required]
        public string BankName { get; set; }
        public string Shaba { get; set; }
        [Required]
        [StringLength(maximumLength: 16, MinimumLength = 16)]
        public string CardNumber { get; set; }
        [Required]
        [StringLength(maximumLength: 2, MinimumLength = 2)]
        public string ExpireDateMonth { get; set; }
        [Required]
        [StringLength(maximumLength: 2, MinimumLength = 2)]
        public string ExpireDateYear { get; set; }
        [Required]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
