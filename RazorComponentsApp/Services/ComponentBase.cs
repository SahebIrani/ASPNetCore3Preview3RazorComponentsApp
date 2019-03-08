using Microsoft.AspNetCore.Components;

using RazorComponentsApp.Services;

namespace RazorComponentsApp
{
    public class ComponentBaseMe : ComponentBase
    {
        // Dependency injection works even if using the
        // InjectAttribute in a component's base class.
        [Inject]
        protected IDataAccess DataRepository { get; set; }
    }
    //@inherits ComponentBase
}
