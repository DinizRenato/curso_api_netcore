using System.Threading.Tasks;
using Api.Domain.dtos;

namespace Api.Domain.Interfaces.Services.User
{
    public interface ILoginService
    {
        Task<object> findByLogin(LoginDto user);
    }
}
