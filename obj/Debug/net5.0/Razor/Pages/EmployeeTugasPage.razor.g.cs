#pragma checksum "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\Pages\EmployeeTugasPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9af385ff814f53f7ea9cf1bcc5d5906a544396ca"
// <auto-generated/>
#pragma warning disable 1591
namespace Fe_Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\_Imports.razor"
using Fe_Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\_Imports.razor"
using Fe_Blazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeetugaspage")]
    public partial class EmployeeTugasPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" href=\"css/style.css\">");
#nullable restore
#line 5 "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\Pages\EmployeeTugasPage.razor"
 if(Employees == null){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"spinner\"></div>");
#nullable restore
#line 7 "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\Pages\EmployeeTugasPage.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-deck");
#nullable restore
#line 11 "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\Pages\EmployeeTugasPage.razor"
     foreach (var emp in Employees)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card m-3");
            __builder.AddAttribute(6, "style", "min-width: 15rem; max-width:30%");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-header");
            __builder.OpenElement(9, "h3");
            __builder.AddContent(10, 
#nullable restore
#line 15 "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\Pages\EmployeeTugasPage.razor"
                     emp.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, " ");
            __builder.AddContent(12, 
#nullable restore
#line 15 "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\Pages\EmployeeTugasPage.razor"
                                    emp.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            <img class=\"card-img-top img-thumbnail\" src=\"img/jordinihboss.jpg\">\r\n            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card-footer text-center");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "href", 
#nullable restore
#line 19 "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\Pages\EmployeeTugasPage.razor"
                           $"employeedetail/{emp.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "class", "btn btn-primary m-1");
            __builder.AddContent(19, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.AddMarkupContent(21, "<a href=\"#\" class=\"btn btn-warning m-1\">Edit</a>\r\n                ");
            __builder.AddMarkupContent(22, "<a href=\"#\" class=\"btn btn-danger m-1\">Delete</a>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\Pages\EmployeeTugasPage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 26 "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\Pages\EmployeeTugasPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591