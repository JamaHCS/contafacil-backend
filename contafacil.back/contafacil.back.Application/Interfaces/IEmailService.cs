using contafacil.back.Application.DTOs.Email;
using System.Threading.Tasks;

namespace contafacil.back.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}