#pragma checksum "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "517e9f1c042821bd1f76ba2c542efb78d13a03d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetById), @"mvc.1.0.view", @"/Views/Product/GetById.cshtml")]
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
#line 1 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"517e9f1c042821bd1f76ba2c542efb78d13a03d1", @"/Views/Product/GetById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df904074e080d8b057959c4207386b113f761452", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_GetById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""items-section"">
    <div class=""container"">
        <div class=""h m-3 ms-0"">
            <p>Product Details</p>
        </div>
        <div class=""details d-flex flex-row"">
            <div id=""carouselExampleDark"" class=""carousel"" data-bs-ride=""carousel"">
                <div class=""carousel-indicators"">
                    <button type=""button"" data-bs-target=""#carouselExampleDark"" data-bs-slide-to=""0"" class=""active""
                        aria-current=""true"" aria-label=""Slide 1""></button>
                    <button type=""button"" data-bs-target=""#carouselExampleDark"" data-bs-slide-to=""1""
                        aria-label=""Slide 2""></button>
                    <button type=""button"" data-bs-target=""#carouselExampleDark"" data-bs-slide-to=""2""
                        aria-label=""Slide 3""></button>
                </div>
                <div class=""carousel-inner"">
");
#nullable restore
#line 19 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                      
                        string str = Model.Picture;
                        var pictureList = str.Split(",");
                        foreach(var item in pictureList)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"carousel-item active\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1249, "\"", 1260, 1);
#nullable restore
#line 25 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
WriteAttributeValue("", 1255, item, 1255, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block\" alt=\"...\">\r\n                            </div>\r\n");
#nullable restore
#line 27 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleDark""
                    data-bs-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""visually-hidden"">Previous</span>
                </button>
                <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleDark""
                    data-bs-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""visually-hidden"">Next</span>
                </button>
            </div>
            <div class=""speces"">
                <div class=""Product-Title"">
                    <h4>");
#nullable restore
#line 43 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <hr>\r\n                    <div>\r\n                        Brand:\r\n                                <p class=\"d-inline\">");
#nullable restore
#line 47 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                               Write(Model.ModelLabtop);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"d-inline\">");
#nullable restore
#line 48 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                               Write(Model.ModelMobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                        \r\n                    </div>\r\n                    <div>\r\n                        Availability:\r\n");
#nullable restore
#line 54 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                         if(Model.UnitsInStock > Model.UnitsOnOrder)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"d-inline\">In Stock</p>\r\n");
#nullable restore
#line 57 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"d-inline\">Out Of Stock</p>\r\n");
#nullable restore
#line 61 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div class=\"Product-dimensions\">\r\n                    <h4>Product Description</h4>\r\n                    <hr>\r\n                    <p>\r\n                        ");
#nullable restore
#line 68 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
                <div class=""Product-reviews"">
                    <h4>Product Reviews</h4>
                    <hr>
                    <div>
                        <i class='bx bxs-star'></i>
                        <i class='bx bxs-star'></i>
                        <i class='bx bxs-star'></i>
                        <i class='bx bxs-star'></i>
                        <i class='bx bx-star'></i>
                        <p class=""d-inline"">&nbsp;&nbsp;&nbsp;1 review</p>
                    </div>
                </div>
            </div>
            <div class=""Desc"">
                <div class=""Product-price"">
                    <h4>Product price</h4>
                    <hr>
                    <div class=""price-val"">
");
#nullable restore
#line 89 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                         if(Model.Discount > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"d-inline\">$ ");
#nullable restore
#line 91 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                             Write(Model.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("- ");
#nullable restore
#line 91 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                                               Write(Model.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 92 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"d-inline\">$ ");
#nullable restore
#line 95 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                             Write(Model.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 96 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <div class=""d-flex justify-content-center align-items-center flex-row add-to-cart"">
                        <i class='bx bxs-cart-add add-cart '></i>
                        <p class=""d-inline"">add-to cart</p>
                    </div>
                </div>
            </div>
        </div>
        <div id=""custome-accordion"" class=""d-flex flex-column"">
            <div class=""d-flex flex-row"" id=""ca-title"">
                <span>Description</span>
                <span>Specification</span>
                <span>reviews</span>
            </div>
            <div class=""d-flex flex-row"" id=""ca-body"">
                <div>
                    Body Description:
                    <br>
                    ");
#nullable restore
#line 115 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
               Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div hidden>
                    Body Specification:
                    <br>
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt deserunt minima possimus repellendus corporis aut cum quo quaerat! Qui ducimus voluptates vero! Voluptates earum iure quod eligendi modi beatae quia?
                </div>
                <div hidden>
                    Body review
                    :<br>
                    ");
#nullable restore
#line 125 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
               Write(Model.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
