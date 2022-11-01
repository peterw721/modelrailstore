using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using _92031083_ModelRailStore.Models;

namespace _92031083_ModelRailStore.ViewModels
{
    public class AdminViewModel
    {
    }
    public class RoleViewModel
    {
        public string Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Role Name")]
        public string Name { get; set; }
    }

    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The Scale Preference must be HO / OO / N or ALL")]
        [Display(Name = "Preferred Scale")]  //to determine which scale they prefer for marketing purposes
        [StringLength(3, MinimumLength = 1, ErrorMessage = "Please enter a scale between 1 and 3 characters in length")]
        [RegularExpression("^[A-H-N-O][L-O]*[L]*$", ErrorMessage = "Please enter a Scale as HO / OO / N or ALL.")]
        public string PrefScale { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        public Address Address { get; set; }

        public IEnumerable<SelectListItem> RolesList { get; set; }
    }

}