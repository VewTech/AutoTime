using Library.Schemas;

namespace Web.Core.Services
{
    public interface IIntratimeService
    {
        // Perform a login and return the user
        public Task<User> LoginUser(string user, string pin);
    }
}
