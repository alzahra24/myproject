// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\AddStudent - Copy.razor"
using Students_Challenge.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddStudent")]
    public partial class AddStudent___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\AddStudent - Copy.razor"
       
    Student obj = new Student();
   

    protected async void CreateStudent()
    {
        await studentService.InsertStudentAsync(obj);
        NavigationManager.NavigateTo("Students");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Students");
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentService studentService { get; set; }
    }
}
#pragma warning restore 1591
