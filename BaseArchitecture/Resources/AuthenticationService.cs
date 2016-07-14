using System.Threading.Tasks;
using BaseArchitecture.WebApi.Web.Data;
using BaseArchitecture.WebApi.Web.Data.Models.Authentication;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BaseArchitecture.WebApi.Web.Resources
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(User userModel);
        Task<IdentityUser> FindUser(string userName, string password);
    }

    public class AuthenticationService : IAuthenticationService
    {
        // TODO: Inject from IoC
        private readonly IdentityDbContext<IdentityUser> ctx;
        private readonly UserManager<IdentityUser> userManager; 

        public AuthenticationService()
        {
            this.ctx = new AuthContext();
            userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(ctx));
        }

        public async Task<IdentityResult> RegisterUser(User userModel)
        {
            var user = new IdentityUser
            {
                UserName = userModel.UserName
            };

            var result = await userManager.CreateAsync(user, userModel.Password);

            return result;
        }

        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            var user = await userManager.FindAsync(userName, password);

            return user;
        }
    }
}