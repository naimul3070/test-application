using test_application.Dto;
using test_application.IRepo;
using test_application.Models;

namespace test_application.Repo
{
    public class Cred : ICredential
    {
        public DbA9cc46NaimuldbContext _context;

        public Cred(DbA9cc46NaimuldbContext context)
        {
            _context = context;
        }
        public async Task<int> AddCred(AddCredDto model)
        {
            var data = new Credential()
            {
                IsBlock = model.IsBlock,
                MobileNumber = model.MobileNumber,
                Password = model.Password,
                Role = model.Role,
                UserName = model.UserName,
            };
            await _context.Credentials.AddAsync(data);
            int row = await _context.SaveChangesAsync();
            return row;
        }
    }
}
