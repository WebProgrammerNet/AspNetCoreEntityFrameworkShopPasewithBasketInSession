#pragma checksum "C:\Users\Code\source\repos\Shop_Page\Shop_Page\Views\Cars\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "751136275a29c08ae898b2e14e4d71c8dcd8dee3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Index), @"mvc.1.0.view", @"/Views/Cars/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cars/Index.cshtml", typeof(AspNetCore.Views_Cars_Index))]
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
#line 1 "C:\Users\Code\source\repos\Shop_Page\Shop_Page\Views\_ViewImports.cshtml"
using Shop_Page.Models;

#line default
#line hidden
#line 2 "C:\Users\Code\source\repos\Shop_Page\Shop_Page\Views\_ViewImports.cshtml"
using Shop_Page.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"751136275a29c08ae898b2e14e4d71c8dcd8dee3", @"/Views/Cars/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79d9bc0c641664dffb1c637b0f076f5f8a0d07b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Code\source\repos\Shop_Page\Shop_Page\Views\Cars\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(112, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(119, 21, false);
#line 8 "C:\Users\Code\source\repos\Shop_Page\Shop_Page\Views\Cars\Index.cshtml"
Write(Model.currentCategory);

#line default
#line hidden
            EndContext();
            BeginContext(140, 111, true);
            WriteLiteral("</h2>\r\n<section>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n");
            EndContext();
#line 13 "C:\Users\Code\source\repos\Shop_Page\Shop_Page\Views\Cars\Index.cshtml"
                 foreach (var item in Model.allCars)
                {

                    

#line default
#line hidden
            BeginContext(347, 70, false);
#line 16 "C:\Users\Code\source\repos\Shop_Page\Shop_Page\Views\Cars\Index.cshtml"
               Write(await Html.PartialAsync("~/Views/Shared/_PartialAllCars.cshtml", item));

#line default
#line hidden
            EndContext();
#line 16 "C:\Users\Code\source\repos\Shop_Page\Shop_Page\Views\Cars\Index.cshtml"
                                                                                           ;

                }

#line default
#line hidden
            BeginContext(441, 88, true);
            WriteLiteral("                \r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591