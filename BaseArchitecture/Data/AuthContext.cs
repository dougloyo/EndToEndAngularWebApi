using Microsoft.AspNet.Identity.EntityFramework;

namespace BaseArchitecture.WebApi.Web.Data
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {

        }
    }
}