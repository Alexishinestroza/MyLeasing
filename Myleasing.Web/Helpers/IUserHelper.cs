using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Myleasing.Web.Data.Entities;
using Myleasing.Web.Data.Entities;

namespace Myleasing.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);
    }
}
