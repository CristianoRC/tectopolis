using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class CreateUserDto
    {
        public CreateUserDto()
        {
        }

        public CreateUserDto(string name, string imageUrl, string password, string email)
        {
            Name = name;
            ImageUrl = imageUrl;
            Password = password;
            Email = email;
        }
        [Required] public string Name { get; set; }
        [Required] public string ImageUrl { get; set; }
        [Required] public string Password { get; set; }
        [Required] public string Email { get; set; }
    }
}