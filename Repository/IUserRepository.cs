using rediscachedemoazure.Model;

namespace rediscachedemoazure.Repository
{
    public interface IUserRepository
    {
        public List<User> GetAllUsers();
        public User GetById(int id);
        public Task<User> ValidateUser(LoginRequestDto userRequest);
    }
}
