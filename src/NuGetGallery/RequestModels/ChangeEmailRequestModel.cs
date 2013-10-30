﻿using System.ComponentModel.DataAnnotations;

namespace NuGetGallery
{
    public class ChangeEmailRequestModel
    {
        [Required]
        [StringLength(255)]
        [Display(Name = "New Email Address")]
        //[DataType(DataType.EmailAddress)] - does not work with client side validation
        [RegularExpression(RegisterViewModel.EmailValidationRegex, ErrorMessage = RegisterViewModel.EmailValidationErrorMessage)]
        public string NewEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current Password (for verification)")]
        [StringLength(64)]
        public string Password { get; set; }
    }
}