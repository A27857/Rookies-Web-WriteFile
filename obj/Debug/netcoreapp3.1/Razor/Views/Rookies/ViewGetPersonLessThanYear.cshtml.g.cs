#pragma checksum "C:\Users\LENOVO\Documents\ASP .Net Core Fundamental\Views\Rookies\ViewGetPersonLessThanYear.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbb44910aca1d35115e7ea8ee87d07d3badb39ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rookies_ViewGetPersonLessThanYear), @"mvc.1.0.view", @"/Views/Rookies/ViewGetPersonLessThanYear.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\LENOVO\Documents\ASP .Net Core Fundamental\Views\_ViewImports.cshtml"
using ASP_.Net_Core_Fundamental;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\Documents\ASP .Net Core Fundamental\Views\_ViewImports.cshtml"
using ASP_.Net_Core_Fundamental.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbb44910aca1d35115e7ea8ee87d07d3badb39ef", @"/Views/Rookies/ViewGetPersonLessThanYear.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07d3817c076776f4e1b1699d71ac947cba5a9aa4", @"/Views/_ViewImports.cshtml")]
    public class Views_Rookies_ViewGetPersonLessThanYear : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\LENOVO\Documents\ASP .Net Core Fundamental\Views\Rookies\ViewGetPersonLessThanYear.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 4 "C:\Users\LENOVO\Documents\ASP .Net Core Fundamental\Views\Rookies\ViewGetPersonLessThanYear.cshtml"
      Write(String.Format($"{@item.LastName} {@item.FirstName} - {@item.Gender} - {@item.Age} - {@item.DateOfBirth}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 5 "C:\Users\LENOVO\Documents\ASP .Net Core Fundamental\Views\Rookies\ViewGetPersonLessThanYear.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591