#pragma checksum "D:\DHTX-VB2\Hoc Ky 2 - 2021\Ky Thuat Lap Trinh\ASP_Web_App\WebAppRazor\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "286356eaa97b29a774bda997c6970d09ed891c1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"286356eaa97b29a774bda997c6970d09ed891c1e", @"/Pages/About.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DHTX-VB2\Hoc Ky 2 - 2021\Ky Thuat Lap Trinh\ASP_Web_App\WebAppRazor\Pages\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 6 "D:\DHTX-VB2\Hoc Ky 2 - 2021\Ky Thuat Lap Trinh\ASP_Web_App\WebAppRazor\Pages\About.cshtml"
Write(SayHello("Covid"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<p>It\'s ");
#nullable restore
#line 8 "D:\DHTX-VB2\Hoc Ky 2 - 2021\Ky Thuat Lap Trinh\ASP_Web_App\WebAppRazor\Pages\About.cshtml"
   Write(DateTime.Now.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

<p>ASP.NET Core Razor Pages is a page-focused framework for building dynamic, data-driven web sites with clean separation of concerns. Based on the latest version of ASP.NET from Microsoft - ASP.NET Core, Razor Pages supports cross platform development and can be deployed to Windows, Unix and Mac operating systems.</p>

");
#nullable restore
#line 12 "D:\DHTX-VB2\Hoc Ky 2 - 2021\Ky Thuat Lap Trinh\ASP_Web_App\WebAppRazor\Pages\About.cshtml"
  
    string SayHello(string name)
    {
        return $"Hello, {name}. Welcome to Razor Pages!";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("NameSection", async() => {
                WriteLiteral("\r\n    <p1>Content section</p1>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_About> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_About> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_About>)PageContext?.ViewData;
        public Pages_About Model => ViewData.Model;
    }
}
#pragma warning restore 1591