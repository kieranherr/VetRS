﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VetRS.Models
{
    public class Veteran
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name", Order = -9)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name", Order = -9)]
        public string LastName { get; set; }

        [Display(Name = "Contact #", Order = -9)]
        public string PhoneNumber { get; set; }

        public string Email { get; set; }
        public string ImageLocation { get; set; }

        [Display(Name = "Street", Order = -9)]
        public string VeteranStreet { get; set; }

        [Display(Name = "City", Order = -9)]
        public string VeteranCity { get; set; }

        [Display(Name = "State", Order = -9)]
        public string VeteranState { get; set; }

        [Display(Name = "Zip Code", Order = -9)]
        public int VeteranZipCode { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
