#pragma checksum "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92cf09d1ec99dfeead10d838b2e5448eb59f7458"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAdvance.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\_Imports.razor"
using BlazorAdvance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\_Imports.razor"
using BlazorAdvance.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\_Imports.razor"
using BlazorAdvance.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\_Imports.razor"
using BlazorAdvance.Data.Service;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\Shared\MainLayout.razor"
 
    private void Logout()
    {

        _navigation.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SidebarService _sidebar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentService _student { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigation { get; set; }
    }
}
#pragma warning restore 1591
