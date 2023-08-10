using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rediscachedemoazure.Model;

namespace rediscachedemoazure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        public IActionResult createAccount(AccountCreateRequestDtocs obj)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult DeleteAccount(AccountDeleteRequestDto obj)
        {
            return Ok();
        }
        [HttpGet]
        public IActionResult DepositMoney(AccountCreateRequestDtocs accountcreateReqDto)
        {
            return Ok();
        }
        [HttpGet]
        public IActionResult WithdrawMoney(AccountWithdrawRequestDto obj)
        {
            return Ok();
        }
    }
}
