using AcademicPortal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AcademicPortal.ViewModels
{
	public class ProfileViewModel
	{
		public string UserId { get; set; }
		public ApplicationUser User { get; set; }
		public string RoleName { get; set; }
		public string FullName { get; set; }
		public string Avatar { get; set; }
		public AdminInfo AdminInfo { get; set; }
		public TraineeInfo TraineeInfo { get; set; }
		public StaffInfo StaffInfo { get; set; }
		public TrainerInfo TrainerInfo { get; set; }

		[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 1)]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password { get; set; }

		[DataType(DataType.Password)]
		[Display(Name = "Confirm password")]
		[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
		public string ConfirmPassword { get; set; }

	}
}