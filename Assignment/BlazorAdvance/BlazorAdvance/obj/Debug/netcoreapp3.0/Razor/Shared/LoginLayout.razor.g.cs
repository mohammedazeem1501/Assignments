#pragma checksum "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\Shared\LoginLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ef068352026ef2228c4318e26307911e9a00a72"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class LoginLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "content px-4");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddContent(6, 
#nullable restore
#line 6 "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\Shared\LoginLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SidebarService _sidebar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentService _student { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigation { get; set; }
    }
}
#pragma warning restore 1591
