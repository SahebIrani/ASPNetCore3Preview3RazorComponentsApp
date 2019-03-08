using System.Collections.Generic;
using System.Threading.Tasks;

namespace RazorComponentsApp.Services
{
    public interface IDataAccess
    {
        Task<IReadOnlyList<Customer>> GetAllCustomersAsync();
    }
}
