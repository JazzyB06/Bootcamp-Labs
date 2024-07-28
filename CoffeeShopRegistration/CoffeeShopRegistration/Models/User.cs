using System.ComponentModel.DataAnnotations;
namespace CoffeeShopRegistration.Models
{
	public class User
	{ 

		public int UserId {  get; set; }
		[Required(ErrorMessage = "First name is required")] //If not provided throw this error message
		public string FirstName { get; set; }
		[Required(ErrorMessage = "Last name is required")]
		public string LastName { get; set; }
		[EmailAddress] //check it to see the validation works
		public string Email { get; set; }
		[Required(ErrorMessage = "Password is required")]
		[MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
		public string Password { get; set; }
		//Validation is the process of checking what the user puts in to prevent them from having a choice to mess thing up
	}
}

