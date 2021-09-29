#pragma checksum "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\DeleteCountry.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f913bdef491f34a95b3286041b493331b5f481fa"
// <auto-generated/>
#pragma warning disable 1591
namespace Students_Challenge.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\_Imports.razor"
using Students_Challenge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\_Imports.razor"
using Students_Challenge.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\DeleteCountry.razor"
using Students_Challenge.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DeleteCountry/{Id}")]
    public partial class DeleteCountry : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Delete Country</h2>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, "<h3>Are you sure want to delete this?</h3>\r\n");
            __builder.OpenElement(2, "form");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", " col-md-8");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddMarkupContent(9, "<label>Country Id:</label>\r\n                ");
            __builder.OpenElement(10, "label");
            __builder.AddContent(11, 
#nullable restore
#line 16 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\DeleteCountry.razor"
                        objCountry.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group");
            __builder.AddMarkupContent(15, "<label>Country Name:</label>\r\n                ");
            __builder.OpenElement(16, "label");
            __builder.AddContent(17, 
#nullable restore
#line 20 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\DeleteCountry.razor"
                        objCountry.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "row");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-md-4");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "button");
            __builder.AddAttribute(27, "class", "btn btn-danger");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\DeleteCountry.razor"
                                                                       DeleteCountries

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "button");
            __builder.AddAttribute(33, "class", "btn btn-primary");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\DeleteCountry.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\DeleteCountry.razor"
       
    [Parameter]
    public string Id { get; set; }
    countries objCountry = new countries();
    protected override async Task OnInitializedAsync()
    {
        objCountry = await Task.Run(() => studentService.GetCountryAsync(Convert.ToInt32(Id)));
    }
    protected async void DeleteCountries()
    {
        await studentService.DeleteCountryAsync(objCountry);
        NavigationManager.NavigateTo("Countries");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Countries");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentService studentService { get; set; }
    }
}
#pragma warning restore 1591
