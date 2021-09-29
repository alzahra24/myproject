#pragma checksum "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\EditClass.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "254737e69d15dddc444785887607d0ee4b182852"
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
#line 2 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\EditClass.razor"
using Students_Challenge.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditClass/{Id}")]
    public partial class EditClass : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Edit Class</h2>\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"Name\" class=\"control-label\">Name</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "form", "Name");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\EditClass.razor"
                                                                objclass.name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objclass.name = __value, objclass.name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-md-4");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "class", "btn btn-primary");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\EditClass.razor"
                                                                        UpdateClasses

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "value", "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "class", "btn btn-primary");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\EditClass.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\EditClass.razor"
       
    [Parameter]
    public string Id { get; set; }
    classes objclass = new classes();
    protected override async Task OnInitializedAsync()
    {
        objclass = await Task.Run(() => studentService.GetClassAsync(Convert.ToInt32(Id)));
    }
    protected async void UpdateClasses()
    {
        await studentService.UpdateClassAsync(objclass);
        NavigationManager.NavigateTo("Classes");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Classes");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentService studentService { get; set; }
    }
}
#pragma warning restore 1591