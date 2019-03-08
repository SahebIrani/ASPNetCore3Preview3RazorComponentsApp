using System.Collections.Generic;
using System.Threading.Tasks;

namespace RazorComponentsApp.Services
{
    public class DataAccess : IDataAccess
    {
        // The constructor receives an HttpClient via dependency
        // injection. HttpClient is a default service.
        //public DataAccess(HttpClient client)
        //{
        //}

        public async Task<IReadOnlyList<Customer>> GetAllCustomersAsync()
        {
            IReadOnlyList<Customer> result = new List<Customer>
            {
                new Customer{ FirstName="Sinjul",LastName="MSBH" },
                new Customer{ FirstName="Jack",LastName="Slater" },
            };

            return await Task.FromResult(result);
        }
    }
}
