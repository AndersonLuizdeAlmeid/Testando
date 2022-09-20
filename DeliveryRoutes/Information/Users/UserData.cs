/*using CSharpFunctionalExtensions;
using Microsoft.Extensions.Configuration;

namespace DeliveryRoutes.Information.Users
{
    public class UserData : IUserData
    {
        private readonly string _connectionString;

        public UserData(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("Informix");
        }

        public async Task<Result<EmployeeDTO>> GetEmployeeData(int userCode)
        {
            return await UsersData.GetEmployeeDataByID(userCode, _connectionString);
        }
    }
}
*/