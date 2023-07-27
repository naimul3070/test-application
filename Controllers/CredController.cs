using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test_application.Dto;
using test_application.IRepo;

namespace test_application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CredController : ControllerBase
    {
        private readonly ICredential _repo;

        public CredController(ICredential repo)
        {
            _repo = repo;
        }
        [HttpPost]
        [Route("AddCred")]
        public async Task<int> AddCred(AddCredDto model)
        {
            try
            {
                var data = await _repo.AddCred(model);
                return data;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
