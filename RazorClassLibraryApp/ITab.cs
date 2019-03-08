using Microsoft.AspNetCore.Components;

namespace RazorClassLibraryApp
{
    public interface ITab
    {
        RenderFragment ChildContent { get; }
    }
}
