#pragma checksum "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b713483ad400e66bcdc148e59348977b3b240ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Detail), @"mvc.1.0.view", @"/Views/Shop/Detail.cshtml")]
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
#line 1 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\_ViewImports.cshtml"
using XanElectronics.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\_ViewImports.cshtml"
using XanElectronics.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b713483ad400e66bcdc148e59348977b3b240ba", @"/Views/Shop/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"644cd9a76a4ae02722074aa55e401440db82eec1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 800px;height: 800px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product-thumb"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 360px;height: 360px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- breadcrumb-section start -->
<nav class=""breadcrumb-section theme3 bg-lighten2 pt-110 pb-110"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <ol class=""breadcrumb bg-transparent m-0 p-0 align-items-center justify-content-center"">
                    <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                    <li class=""breadcrumb-item""><a href=""shop-grid-3-column.html"">Bags & Shoes</a></li>
                    <li class=""breadcrumb-item active"" aria-current=""page"">Originals Windbreaker Winter Jacket</li>
                </ol>
            </div>
        </div>
    </div>
</nav>
<!-- breadcrumb-section end -->
<!-- product-single start -->
<input type=""hidden"" id=""pageName"" value=""detail"" />
<section class=""product-single theme3 pt-60"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 mb-5 mb-lg-0"">
                <div class=""position-relative"">
");
#nullable restore
#line 28 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml"
                     if (Model.IsNew)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge badge-danger top-right\">New</span>\r\n");
#nullable restore
#line 31 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"product-sync-init mb-20\">\r\n                    <div class=\"single-product\">\r\n                        <div class=\"product-thumb\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1b713483ad400e66bcdc148e59348977b3b240ba6422", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1446, "~/assets/img/product/", 1446, 21, true);
#nullable restore
#line 36 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml"
AddHtmlAttributeValue("", 1467, Model.ProductImages.ElementAt(0).ImageUrl, 1467, 42, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <!-- single-product end -->\r\n");
#nullable restore
#line 41 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml"
                     foreach (var item in Model.ProductImages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"single-product\">\r\n                            <div class=\"product-thumb\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1b713483ad400e66bcdc148e59348977b3b240ba8727", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1952, "~/assets/img/product/", 1952, 21, true);
#nullable restore
#line 45 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml"
AddHtmlAttributeValue("", 1973, item.ImageUrl, 1973, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 49 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <!-- single-product end -->\r\n                </div>\r\n                <div class=\"product-sync-nav single-product\">\r\n");
#nullable restore
#line 53 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml"
                     foreach (var image in Model.ProductImages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"single-product\">\r\n                            <div class=\"product-thumb\">\r\n                                <a href=\"javascript:void(0)\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1b713483ad400e66bcdc148e59348977b3b240ba11388", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2581, "~/assets/img/product/", 2581, 21, true);
#nullable restore
#line 57 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml"
AddHtmlAttributeValue("", 2602, image.ImageUrl, 2602, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 61 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"col-lg-6 mt-5 mt-md-0\">\r\n                <div class=\"single-product-info\">\r\n                    <div class=\"single-product-head\">\r\n                        <h2 class=\"title mb-20\">");
#nullable restore
#line 67 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml"
                                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <div class=\"star-content mb-20\">\r\n");
#nullable restore
#line 69 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml"
                             for (int i = 0; i < Model.Star; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"star-on\"><i class=\"ion-ios-star\"></i> </span>\r\n");
#nullable restore
#line 72 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <a href=""#"" id=""write-comment"">
                                <span class=""ml-2""><i class=""far fa-comment-dots""></i></span>
                                Read reviews <span>(1)</span>
                            </a>
                            <a href=""#"" data-toggle=""modal"" data-target=""#exampleModalCenter"">
                                <span class=""edite"">
                                    <i class=""far fa-edit""></i>
                                </span> Write a review
                            </a>
                        </div>
                    </div>
                    <div class=""product-body mb-40"">
                        <div class=""d-flex align-items-center mb-30"">
                            <h6 class=""product-price mr-20"">
");
#nullable restore
#line 87 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml"
                                 if (Model.DisCountRate > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <del class=\"del\"> ");
#nullable restore
#line 89 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml"
                                                 Write(Model.Price.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n                                    <span class=\"onsale\"> ");
#nullable restore
#line 90 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml"
                                                     Write(Model.ResultPrice.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"badge position-static bg-dark rounded-0\">Save ");
#nullable restore
#line 91 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml"
                                                                                          Write(Model.DisCountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</span>\r\n");
#nullable restore
#line 92 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"onsale\"> ");
#nullable restore
#line 95 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml"
                                                     Write(Model.ResultPrice.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 96 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </h6>
                            
                        </div>
                        <p>description</p>
                    </div>
                    <div class=""product-footer"">
                        <div class=""product-count style d-flex flex-column flex-sm-row mt-30 mb-30"">
                            <div class=""count d-flex"">
                                <input type=""number"" min=""1"" max=""10"" step=""1"" value=""1"" id=""addProductCount"">
                                <div class=""button-group"">
                                    <button class=""count-btn increment""><i class=""fas fa-chevron-up""></i></button>
                                    <button class=""count-btn decrement""><i class=""fas fa-chevron-down""></i></button>
                                </div>
                            </div>
                            <div>
                                <button class=""btn theme-btn--dark3 btn--xl mt-5 mt-sm-0 rounded-5 ml-3 addToBasket"" data-id=""");
#nullable restore
#line 112 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\xanelectronics\Views\Shop\Detail.cshtml"
                                                                                                                         Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                    <span class=""mr-2""><i class=""ion-android-add""></i></span>
                                    Add to cart
                                </button>
                            </div>
                        </div>
                        <div class=""addto-whish-list"">
                            <a href=""#""><i class=""icon-heart""></i> Add to wishlist</a>
                            <a href=""#""><i class=""icon-shuffle""></i> Add to compare</a>
                        </div>
                        <div class=""pro-social-links mt-10"">
                            <ul class=""d-flex align-items-center"">
                                <li class=""share"">Share</li>
                                <li><a href=""#""><i class=""ion-social-facebook""></i></a></li>
                                <li><a href=""#""><i class=""ion-social-twitter""></i></a></li>
                                <li><a href=""#""><i class=""ion-social-google""></i></a></li>
                             ");
            WriteLiteral(@"   <li><a href=""#""><i class=""ion-social-pinterest""></i></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- product-single end -->
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script >
     $("".count"").each(function () {
        var count = $(this),
            input = count.find('input[type=""number""]'),
            increament = count.find("".increment""),
            decreament = count.find("".decrement""),
            minValue = input.attr(""min""),
            maxValue = input.attr(""max"");
        increament.on(""click"", function () {
          var oldValue = parseFloat(input.val());
    
          if (oldValue >= maxValue) {
            var newVal = oldValue;
          } else {
            var newVal = oldValue + 1;
          }
    
          count.find(""input"").val(newVal);
          count.find(""input"").trigger(""change"");
        });
        decreament.on(""click"", function () {
          var oldValue = parseFloat(input.val());
    
          if (oldValue <= minValue) {
            var newVal = oldValue;
          } else {
            var newVal = oldValue - 1;
          }
    
          count.find(""input"").val(newVal);
          count.find(""input""");
                WriteLiteral(").trigger(\"change\");\r\n        });\r\n      });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
