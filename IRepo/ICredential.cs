using test_application.Dto;

namespace test_application.IRepo
{
    public interface ICredential
    {
        public Task<int> AddCred(AddCredDto model);
    }
}
