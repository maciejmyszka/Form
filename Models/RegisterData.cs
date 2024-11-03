using System.ComponentModel.DataAnnotations;

namespace Form.Models
{
    public class RegisterData
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        public string Surname { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).+$")]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [Range(10, 80)]
        public int Age { get; set; }
        public CityEnum City { get; set; }

        public enum CityEnum { Krakow = 1, Warszawa = 2, Wroclaw = 3, Gdansk = 4, Katowice = 5 }
    }
}
