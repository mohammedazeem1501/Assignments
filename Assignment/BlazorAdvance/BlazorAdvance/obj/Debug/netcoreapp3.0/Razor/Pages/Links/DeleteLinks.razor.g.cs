#pragma checksum "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\Pages\Links\DeleteLinks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c5c79c15ae2cb4ec25072fcf17b8d2eb4f4f91f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAdvance.Pages.Links
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/DeleteLink/{CurrentID}")]
    public partial class DeleteLinks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>DeleteStudent</h3>\r\n");
            __builder.AddMarkupContent(1, "<h3>Do you really want to Delete this Entry ?</h3>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-8");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form-group");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddMarkupContent(11, "<label>Employee ID : </label>\r\n            ");
            __builder.OpenElement(12, "label");
            __builder.AddContent(13, 
#nullable restore
#line 8 "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\Pages\Links\DeleteLinks.razor"
                    sidebar.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-group");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.AddMarkupContent(19, "<label>Link Name : </label>\r\n            ");
            __builder.OpenElement(20, "label");
            __builder.AddContent(21, 
#nullable restore
#line 12 "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\Pages\Links\DeleteLinks.razor"
                    sidebar.LinkName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.AddMarkupContent(27, "<label>Link Address : </label>\r\n            ");
            __builder.OpenElement(28, "label");
            __builder.AddContent(29, 
#nullable restore
#line 16 "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\Pages\Links\DeleteLinks.razor"
                    sidebar.LinkAddress

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n       \r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "row");
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col-md-4");
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "form-group");
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "button");
            __builder.AddAttribute(45, "class", "btn-btn-danger");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\Pages\Links\DeleteLinks.razor"
                                                                   Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "type", "button");
            __builder.AddAttribute(51, "class", "btn-btn-primary");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\Pages\Links\DeleteLinks.razor"
                                                                    Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Azeem Faisal\source\repos\BlazorAdvance\BlazorAdvance\Pages\Links\DeleteLinks.razor"
 
    [Parameter]
    public string CurrentID { get; set; }

    Sidebar sidebar = new Sidebar();
    protected override async Task OnInitializedAsync()
    {
        sidebar = _sidebar.GetLinksById(Convert.ToInt32(CurrentID));
    }


    private void Delete()
    {
        _sidebar.Delete(sidebar);
        _navigation.NavigateTo("Link");
    }
    private void Cancel()
    {
        _navigation.NavigateTo("Link");
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