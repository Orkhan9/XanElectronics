#pragma checksum "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dedfdd755f03944d5a31e3ab9fed18f811af67cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
#line 1 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\_ViewImports.cshtml"
using XanElectronics.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\_ViewImports.cshtml"
using XanElectronics.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dedfdd755f03944d5a31e3ab9fed18f811af67cf", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"644cd9a76a4ae02722074aa55e401440db82eec1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("first-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/banner/2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- breadcrumb-section start -->
<nav class=""breadcrumb-section theme1 bg-lighten2 pt-110 pb-110"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""section-title text-center mb-15"">
                    <h2 class=""title text-dark text-capitalize"">Bags & Shoes</h2>
                </div>
            </div>
            <div class=""col-12"">
                <ol class=""breadcrumb bg-transparent m-0 p-0 align-items-center justify-content-center"">
                    <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                    <li class=""breadcrumb-item active"" aria-current=""page"">Bags &amp; Shoes</li>
                </ol>
            </div>
        </div>
    </div>
</nav>
<!-- breadcrumb-section end -->
<!-- product tab start -->
<input type=""hidden"" id=""pageName"" value=""shop"" />
<div class=""product-tab bg-white pt-80 pb-50"">
    <div class=""container"">
        <div class=""row"">
            <div class");
            WriteLiteral(@"=""col-lg-9 mb-30"">
                <div class=""grid-nav-wraper bg-lighten2 mb-30"">
                    <div class=""row align-items-center"">
                        <div class=""col-12 col-md-6 mb-3 mb-md-0"">
                            <nav class=""shop-grid-nav"">
                                <ul class=""nav nav-pills align-items-center"" id=""pills-tab"" role=""tablist"">
                                    <li class=""nav-item"">
                                        <a class=""nav-link active"" id=""pills-home-tab"" data-toggle=""pill""
                                           href=""#pills-home"" role=""tab"" aria-controls=""pills-home""
                                           aria-selected=""true"">
                                            <i class=""fa fa-th""></i>

                                        </a>
                                    </li>
                                    <li class=""nav-item mr-0"">
                                        <a class=""nav-link"" id=""pills-profile-tab"" data-t");
            WriteLiteral(@"oggle=""pill""
                                           href=""#pills-profile"" role=""tab"" aria-controls=""pills-profile""
                                           aria-selected=""false""><i class=""fa fa-list""></i></a>
                                    </li>
");
            WriteLiteral(@"                                </ul>
                            </nav>
                        </div>
                        <div class=""col-12 col-md-6 position-relative"">
                            <div class=""shop-grid-button d-flex align-items-center"">
");
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                </div>
                <!-- product-tab-nav end -->
                <div class=""tab-content"" id=""pills-tabContent"">
                    <div class=""tab-pane fade show active"" id=""pills-home"" role=""tabpanel""
                         aria-labelledby=""pills-home-tab"">
                        <div class=""row grid-view theme1"" id=""productList"">
");
#nullable restore
#line 77 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                             foreach (var item in Model.Products)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-sm-6 col-lg-4 col-xl-3 mb-30"">
                                    <div class=""card product-card"">
                                        <div class=""card-body"">
                                            <div class=""product-thumbnail position-relative"">
");
#nullable restore
#line 83 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                 if (item.DisCountRate > 0)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"badge badge-success top-left\">-");
#nullable restore
#line 85 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                                                           Write(item.DisCountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</span>\r\n");
#nullable restore
#line 86 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                 if (item.IsNew)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"badge badge-danger top-right\">New</span>\r\n");
#nullable restore
#line 90 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dedfdd755f03944d5a31e3ab9fed18f811af67cf11325", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 92 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                     foreach (var prImage in item.ProductImages.Take(1))
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dedfdd755f03944d5a31e3ab9fed18f811af67cf12028", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5675, "~/assets/img/product/", 5675, 21, true);
#nullable restore
#line 94 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
AddHtmlAttributeValue("", 5696, prImage.ImageUrl, 5696, 17, false);

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
                WriteLiteral("\r\n");
#nullable restore
#line 95 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                <!-- product links -->
                                                <ul class=""product-links d-flex justify-content-center"">
                                                    <li>
                                                        <a href=""wishlist.html"">
                                                            <span data-toggle=""tooltip"" data-placement=""bottom""
                                                                  title=""add to wishlist"" class=""icon-heart""> </span>
                                                        </a>
                                                    </li>
                                                    <li>
                                                        <a href=""#"" data-toggle=""modal"" data-target=""#compare"">
                                                            <span data-toggle=""tooltip"" data-placement=""bottom""
                                                                  t");
            WriteLiteral(@"itle=""Add to compare"" class=""icon-shuffle""></span>
                                                        </a>
                                                    </li>
                                                    <li>
                                                        <a href=""#"" data-toggle=""modal"" data-target=""#quick-view"">
                                                            <span data-toggle=""tooltip"" data-placement=""bottom""
                                                                  title=""Quick view"" class=""icon-magnifier""></span>
                                                        </a>
                                                    </li>
                                                </ul>
                                                <!-- product links end-->
                                            </div>
                                            <div class=""product-desc py-0"">
                                                <h3 class=""title"">");
            WriteLiteral("\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dedfdd755f03944d5a31e3ab9fed18f811af67cf18531", async() => {
                WriteLiteral("\r\n                                                        ");
#nullable restore
#line 124 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 123 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </h3>\r\n                                                <div class=\"star-rating\">\r\n");
#nullable restore
#line 128 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                     for (int i = 0; i < item.Star; i++)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"ion-ios-star\"></span>\r\n");
#nullable restore
#line 131 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </div>\r\n                                                <div class=\"d-flex align-items-center justify-content-between\">\r\n\r\n");
#nullable restore
#line 135 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                     if (item.DisCountRate > 0)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <h6 class=\"product-price\">\r\n                                                            <del class=\"del\">$ ");
#nullable restore
#line 138 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                                          Write(item.Price.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n                                                            <span class=\"onsale\">$ ");
#nullable restore
#line 139 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                                              Write(item.ResultPrice.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                        </h6>\r\n");
#nullable restore
#line 141 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <h6 class=\"product-price\">$ ");
#nullable restore
#line 144 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                                               Write(item.Price.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 145 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <button class=\"pro-btn\">\r\n                                                        <i class=\"icon-basket addToBasket\" data-id=\"");
#nullable restore
#line 147 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                                                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""></i>
                                                    </button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- product-list End -->
                                </div>
");
#nullable restore
#line 155 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-12"">
                        <nav class=""pagination-section mt-30"">
                            <div class=""row align-items-center"">
                                <div class=""col-12"">
                                    <ul class=""pagination justify-content-center"">
                                        <li class=""page-item paginationItems"">
                                            <i class=""fas fa-angle-double-left fa-lg"" id=""previous"" style=""cursor:pointer""></i>
                                        </li>
");
#nullable restore
#line 168 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                         for (int i = 1; i <= ViewBag.PageCount; i++)
                                        {
                                            if (i < 5)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"page-item paginationItems\"><a class=\"page-link\" data-page=\"");
#nullable restore
#line 172 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 172 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                                                                                     Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 173 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"page-item paginationItems d-none\"><a class=\"page-link\" data-page=\"");
#nullable restore
#line 176 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                                                                                        Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 176 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                                                                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 177 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <li class=""page-item paginationItems"">
                                                <i class=""fas fa-angle-double-right fa-lg"" id=""next"" style=""cursor:pointer""></i>
                                            </li>
                                    </ul>
                                    <input type=""hidden"" id=""pageCount""");
            BeginWriteAttribute("value", " value=\"", 11992, "\"", 12018, 1);
#nullable restore
#line 183 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
WriteAttributeValue("", 12000, ViewBag.PageCount, 12000, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                </div>
                            </div>
                        </nav>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 mb-30 order-last"">
                <aside class=""left-sidebar theme1"">
                    <!--<div class=""search-filter"">
                        <form action=""#"">
                            <div class=""check-box-inner mt-10"">
                                <h4 class=""title"">Filter By</h4>
                                <h4 class=""sub-title pt-10"">Categories</h4>
                                <form method=""get"">
");
#nullable restore
#line 198 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                     foreach (var category in Model.Categories)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"filter-check-box\">\r\n                                            <input type=\"checkbox\" id=\"20820\" \r\n                                                   data-id=\"");
#nullable restore
#line 202 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                       Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" onchange=\"this.form.submit()\">\r\n                                            <label for=\"20820\">");
#nullable restore
#line 203 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                          Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>(");
#nullable restore
#line 203 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                                                Write(category.ProductCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span></label>\r\n                                        </div>\r\n");
#nullable restore
#line 205 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                    }                              

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </form>
                            </div>-->
                            <!-- check-box-inner -->
                            <!--<div class=""check-box-inner mt-10"">
                                <h4 class=""sub-title"">Price</h4>
                                <div class=""price-filter mt-10"">
                                    <div class=""price-slider-amount"">
                                        <input type=""text"" id=""amount"" name=""price"" readonly
                                               placeholder=""Add Your Price"" />
                                    </div>
                                    <div id=""slider-range""></div>
                                </div>
                            </div>
                            <div class=""check-box-inner mt-10"">
                                <h4 class=""sub-title"">Brand</h4>
");
#nullable restore
#line 221 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                 foreach (var brand in Model.Brands)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"filter-check-box\">\r\n                                        <input type=\"checkbox\" id=\"20824\">\r\n                                        <label for=\"20824\">");
#nullable restore
#line 225 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                      Write(brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                    </div>\r\n");
#nullable restore
#line 227 "C:\Users\orkhan\OneDrive\Desktop\my projects\xanelectronics\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </form>
                    </div>-->
                    <!--second banner start-->
                    <div class=""banner hover-animation position-relative overflow-hidden"">
                        <a href=""shop-grid-4-column.html"" class=""d-block"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dedfdd755f03944d5a31e3ab9fed18f811af67cf35583", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </a>\r\n                    </div>\r\n                    <!--second banner end-->\r\n                </aside>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- product tab end -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
