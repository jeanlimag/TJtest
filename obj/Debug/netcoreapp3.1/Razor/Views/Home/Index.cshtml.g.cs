#pragma checksum "C:\Users\ocelo\source\repos\TJTest\TJTest\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dd0c9716487a2cdc418a5c6cd0bfbeb1ceff312"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ocelo\source\repos\TJTest\TJTest\Views\_ViewImports.cshtml"
using TJTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ocelo\source\repos\TJTest\TJTest\Views\_ViewImports.cshtml"
using TJTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ocelo\source\repos\TJTest\TJTest\Views\Home\Index.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ocelo\source\repos\TJTest\TJTest\Views\Home\Index.cshtml"
using System.Web.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ocelo\source\repos\TJTest\TJTest\Views\Home\Index.cshtml"
using System.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ocelo\source\repos\TJTest\TJTest\Views\Home\Index.cshtml"
using System.Web.WebPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ocelo\source\repos\TJTest\TJTest\Views\Home\Index.cshtml"
using System.IdentityModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dd0c9716487a2cdc418a5c6cd0bfbeb1ceff312", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fa93530288d3f2a7576035e6bb910d9c6aa5072", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TJTest.Models.TJTestViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\ocelo\source\repos\TJTest\TJTest\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<link rel=""preconnect"" href=""https://fonts.googleapis.com"">
<link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
<link href=""https://fonts.googleapis.com/css2?family=Azeret+Mono:wght@100;700;900&display=swap"" rel=""stylesheet"">


<div class=""home"">
    <h1>TJTest</h1>
    <div class=""all"">
        <div class=""select-client"">
            <h2>Search Client</h2>

            <input type=""text"" placeholder=""Client"" class=""name"" id=""txtClientName"">

            <div class=""buttons"">
                <input type=""submit"" class=""submit"" value=""Search"" onclick=""SearchClient()"">
                <input type=""submit"" class=""submit"" value=""Register"" onclick=""RegisterNewClient()"" />
            </div>

           
          
                <div class=""result"" id=""result-client"" style=""visibility:hidden;"">
                    <table>
                        <tr>
                            <td>
                                <label id=""idClientlbl""></label>
                     ");
            WriteLiteral(@"       </td>
                            <td>
                                <label id=""clientNamelbl""></label>
                            </td>
                        </tr>
                    </table>
                </div>

        </div>
        <div class=""register-product"">
            <h2>Register Product</h2>
            <input type=""text"" placeholder=""Product"" class=""product txt"">
            <input type=""text"" placeholder=""Price"" readonly class=""txt"" id=""price"">
            <input type=""submit"" class=""submit"" value=""Register Product"">
        </div>
        <div class=""register-order"">
            <h2>Register Order</h2>
            <input type=""text"" placeholder=""Product"" class=""product txt"">
            <input type=""text"" placeholder=""Price"" readonly class=""txt"" id=""price"">
            <input type=""text"" placeholder=""Amount"" class=""txt"" id=""amount"">
            <input type=""text"" placeholder=""Total Price"" readonly class=""txt"" id=""total-price"">
            <input type=""submi");
            WriteLiteral(@"t"" class=""submit"" value=""Register Order"">
        </div>
        <div class=""search-order"">
            <h2>Search Order</h2>
            <input type=""text"" placeholder=""Client"" class=""name txt""><br><br>
            <input type=""text"" placeholder=""Product"" class=""product txt""><br><br>
            <input type=""submit"" class=""submit"" value=""Search"">

            <div class=""result"" id=""result-order"">

            </div>
        </div>
    </div>

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TJTest.Models.TJTestViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
