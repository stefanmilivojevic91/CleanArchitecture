using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using LoginRequest = Domain.UseCases.Login.Request;
using LoginResponse = Domain.UseCases.Login.Response;
using Domain.Commons;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUseCase<LoginRequest, Either<LoginResponse, NullUseCaseResponse>> _loginUseCase;

        public LoginController(IUseCase<LoginRequest, Either<LoginResponse, NullUseCaseResponse>> loginUseCase)
        {
            _loginUseCase = loginUseCase;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var request = new LoginRequest
            {
                Username = "Stefan",
                Password = "123456S"
            };

            var useCaseResponse = await _loginUseCase.Execute(request);

            return useCaseResponse.Match<IActionResult>(item => Ok(item), item => NotFound(item));
        }

        // GET: api/Login/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {

        }
    }
}
