#pragma checksum "D:\itechproject\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25db7baf20de8648b106033e0025e7c10f672ab4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_GetById), @"mvc.1.0.view", @"/Views/Order/GetById.cshtml")]
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
#line 1 "D:\itechproject\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\itechproject\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\itechproject\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\itechproject\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.pagination;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25db7baf20de8648b106033e0025e7c10f672ab4", @"/Views/Order/GetById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dd424cdfade54604a18dccd835c985414b57402", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_GetById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"container mt-3\">\r\n    <h2>Show Order details</h2>\r\n\r\n    <table class=\"table table-bordered\">\r\n         <tr>\r\n            <th>Customer</th>\r\n");
#nullable restore
#line 10 "D:\itechproject\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
             foreach(var item in ViewBag.Cust)
            {
                if(item.Id == Model.CustomerId)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 14 "D:\itechproject\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
                   Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 15 "D:\itechproject\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
            WriteLiteral("         <tr>\r\n            <th>Payment Method</th>\r\n           <td>");
#nullable restore
#line 24 "D:\itechproject\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
          Write(Model.Payment);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n            <th>Shipper</th>\r\n            <td>");
#nullable restore
#line 27 "D:\itechproject\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
           Write(Model.Shipper);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n        </tr>\r\n        \r\n");
            WriteLiteral("        <tr>\r\n            <th>Freight</th>\r\n            <td>");
#nullable restore
#line 36 "D:\itechproject\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
           Write(Model.Freight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Transaction Status</th>\r\n            <td>");
#nullable restore
#line 40 "D:\itechproject\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
           Write(Model.Freight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n \r\n");
            WriteLiteral("    </table>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25db7baf20de8648b106033e0025e7c10f672ab46896", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    \r\n</div>\r\n \r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
