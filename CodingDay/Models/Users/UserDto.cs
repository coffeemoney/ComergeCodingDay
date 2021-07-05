using CodingDay.Entities.Users;

namespace CodingDay.Models.Users
{
    public class UserDto
    {
        public UserDto() { }

        public UserDto(User user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
