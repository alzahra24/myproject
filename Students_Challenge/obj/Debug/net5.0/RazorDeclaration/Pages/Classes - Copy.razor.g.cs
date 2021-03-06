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
#line 2 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\Classes - Copy.razor"
using Students_Challenge.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\Classes - Copy.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Classes")]
    public partial class Classes___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\Classes - Copy.razor"
       
private int count = 0;
private int countc = 0;
[Parameter]
public string ClassID { get; set; }
classes objclass = new classes();
countries objcountry = new countries();
List<Student> EmpObj;
List<classes> ClassObj;
List<countries> CountryObj;

protected override async Task OnInitializedAsync()
{
    EmpObj = await Task.Run(() => studentService.GetAllStudentsAsync());
    ClassObj = await Task.Run(() => studentService.GetAllClassesAsync());
    CountryObj = await Task.Run(() => studentService.GetAllCountriesAsync());
    foreach (var EmpObjRow in EmpObj)
    {
        objclass = await Task.Run(() => studentService.GetClassAsync(Convert.ToInt32(EmpObjRow.class_id)));
        objcountry = await Task.Run(() => studentService.GetCountryAsync(Convert.ToInt32(EmpObjRow.country_id)));
    }
}

public string GetClassName(int class_id)
{

    return ClassObj[class_id - 1].name;
}

public string GetCountryName(int country_id)
{

    return CountryObj[country_id - 1].name;
}


public int GetStudPerCla()

{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\Classes - Copy.razor"
     foreach (var cla in ClassObj)
    {
        count = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\Classes - Copy.razor"
         foreach (var c in EmpObj)
        {

            if (cla.id == c.class_id)
            {
                count++;
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\Classes - Copy.razor"
         

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\Classes - Copy.razor"
     
    return count;

}

public int GetStudPerCount()
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\Classes - Copy.razor"
     foreach (var cla in ClassObj)
    {
        countc = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\Classes - Copy.razor"
         foreach (var c in EmpObj)
            {
                if (cla.id == c.country_id)
                {

                    countc++;

                }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\Classes - Copy.razor"
             

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\Classes - Copy.razor"
         
        return countc;
    }


    int age = 0;
    int Sumofage = 0;
    int avrage = 0;
    int countstud = 0;

    private void avgAges()
   
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 158 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\Classes - Copy.razor"
         foreach (var stu in EmpObj)
        {
            DateTime now = DateTime.Today;
            age = now.Year - stu.date_of_birth.Year;
            if (now < stu.date_of_birth.AddYears(age))
            {
                Sumofage += age;
                countstud++;

                age--;

            }

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 171 "C:\Users\User\Downloads\Students_Challenge\Students_Challenge\Pages\Classes - Copy.razor"
         
   
        avrage = Sumofage / countstud;
       
        
    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentService studentService { get; set; }
    }
}
#pragma warning restore 1591
