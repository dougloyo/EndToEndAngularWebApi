using System.Threading.Tasks;
using System.Web.Http;
using BaseArchitecture.WebApi.Web.Data.Models.Authentication;
using BaseArchitecture.WebApi.Web.Resources;
using Microsoft.AspNet.Identity;

namespace BaseArchitecture.WebApi.Web.Api.Controllers
{
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
        private AuthenticationService authService = null;

        public AccountController()
        {
            authService = new AuthenticationService();
        }

        // POST api/Account/Register
        [AllowAnonymous]
        [Route("Register")]
        public async Task<IHttpActionResult> Register(User userModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await authService.RegisterUser(userModel);

            var errorResult = GetErrorResult(result);

            if (errorResult != null)
                return errorResult;

            return Ok();
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
                return InternalServerError();

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                    foreach (string error in result.Errors)
                        ModelState.AddModelError("", error);

                if (ModelState.IsValid)
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();

                return BadRequest(ModelState);
            }

            return null;
        }
    }
}
