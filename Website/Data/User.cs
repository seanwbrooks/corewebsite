using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Website.Data
{
    public class User
    {
        public int UserID { get; set; }

        [Required, StringLength(50)]
        public string FirstName { get; set; }

        [Required, StringLength(50)]
        public string LastName { get; set; }

        [Required, StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string AddressLine1 { get; set; }
        [StringLength(50)]
        public string AddressLine2 { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(50)]
        public string State { get; set; }
        [Range(5, 9)]
        public int ZipCode { get; set; }

    }
}
