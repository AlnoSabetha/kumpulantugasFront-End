#pragma checksum "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\Pages\DetailDepartment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53cae685a1c1b1039bc12abc5da68f02fb371b74"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/departmentdetail/{id}")]
    public partial class DetailDepartment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Detail Department</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Department Id : ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\Pages\DetailDepartment.razor"
                    Department.DepartmentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, "Department Name : ");
            __builder.AddContent(7, 
#nullable restore
#line 6 "D:\Front-end (matkul)\Fe_Blazor\Fe_Blazor\Pages\DetailDepartment.razor"
                      Department.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
