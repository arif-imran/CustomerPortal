using System;
using System.Threading.Tasks;
using CustomerPortal.Facade.Models;

namespace CustomerPortal.Facade.Facades
{
    public interface IAuthenticationHelperWrapper
    {
        Task<IdentityModel.Client.TokenResponse> GetUserToken(string email, string password, bool usingRefreshTokens = true);

        Task<ReauthenticationResponse<TResult>> TraverseReauth<TResult>(Func<Task<TResult>> restCall, string refreshToken);
    }
}