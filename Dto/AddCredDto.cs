
namespace test_application.Dto
{
    public class AddCredDto
    {
        public string UserName { get; set; } = null!;

        public long MobileNumber { get; set; }

        public string Password { get; set; } = null!;

        public long Role { get; set; }

        public bool IsBlock { get; set; }
    }
}
