using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rediscachedemoazure.Model;
using rediscachedemoazure.Repository;

namespace rediscachedemoazure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly object _iuserRepository;

        public UsersController(IUserRepository iuserrepository)
        {
            _iuserRepository = iuserrepository;

        }

        [HttpPost]
        public async Task<IActionResult> CreateAccounty([FromBody] LoginRequestDto loginrequest)
        {
            // User user = await _userRepository.ValidateUser(loginrequest);
            return Ok();
        }


        [HttpPost]
        public async Task<IActionResult> DeleteAccounty([FromBody] LoginRequestDto loginrequest)
        {
            //  User user = await _userRepository.ValidateUser(loginrequest);
            return Ok();
        }


        [HttpPost]
        public async Task<IActionResult> DepositInAccounty([FromBody] LoginRequestDto loginrequest)
        {
            // User user = await _userRepository.ValidateUser(loginrequest);
            return Ok();
        }


        [HttpPost]
        public async Task<IActionResult> WithdrawFromAccount()
        {
            // User user = await _userRepository.ValidateUser(loginrequest);
            return Ok();
        }
    }
}
