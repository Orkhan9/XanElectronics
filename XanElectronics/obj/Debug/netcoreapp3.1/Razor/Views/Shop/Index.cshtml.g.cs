#pragma checksum "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "025a4a1d2f8cee85e246599938bd54473ddc7a74"
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
#line 1 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\_ViewImports.cshtml"
using XanElectronics.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\_ViewImports.cshtml"
using XanElectronics.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"025a4a1d2f8cee85e246599938bd54473ddc7a74", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"644cd9a76a4ae02722074aa55e401440db82eec1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("first-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/banner/2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
  
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
<div class=""product-tab bg-white pt-80 pb-50"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-9 mb-30"">
                <div class=""grid");
            WriteLiteral(@"-nav-wraper bg-lighten2 mb-30"">
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
                                        <a class=""nav-link"" id=""pills-profile-tab"" data-toggle=""pill""
                                      ");
            WriteLiteral(@"     href=""#pills-profile"" role=""tab"" aria-controls=""pills-profile""
                                           aria-selected=""false""><i class=""fa fa-list""></i></a>
                                    </li>
                                    <li> <span class=""total-products text-capitalize"">There are 13 products.</span></li>
                                </ul>
                            </nav>
                        </div>
                        <div class=""col-12 col-md-6 position-relative"">
                            <div class=""shop-grid-button d-flex align-items-center"">
                                <span class=""sort-by"">Sort by:</span>
                                <button class=""btn-dropdown rounded d-flex justify-content-between"" type=""button""
                                        id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true""
                                        aria-expanded=""false"">
                                    Relevance <span class=""ion-andro");
            WriteLiteral(@"id-arrow-dropdown""></span>
                                </button>
                                <div class=""dropdown-menu shop-grid-menu"" aria-labelledby=""dropdownMenuButton"">
                                    <a class=""dropdown-item"" href=""#"">Relevance</a>
                                    <a class=""dropdown-item"" href=""#""> Name, A to Z</a>
                                    <a class=""dropdown-item"" href=""#""> Name, Z to A</a>
                                    <a class=""dropdown-item"" href=""#""> Price, low to high</a>
                                    <a class=""dropdown-item"" href=""#""> Price, high to low</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- product-tab-nav end -->
                <div class=""tab-content"" id=""pills-tabContent"">
                    <div class=""tab-pane fade show active"" id=""pills-home"" role=""tabpanel""
                        ");
            WriteLiteral(" aria-labelledby=\"pills-home-tab\">\r\n                        <div class=\"row grid-view theme1\" id=\"productList\">\r\n");
#nullable restore
#line 76 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                             foreach (var item in Model)
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
#line 82 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                 if (item.DisCountRate > 0)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"badge badge-success top-left\">-");
#nullable restore
#line 84 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                                                           Write(item.DisCountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</span>\r\n");
#nullable restore
#line 85 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                 if (item.IsNew)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"badge badge-danger top-right\">New</span>\r\n");
#nullable restore
#line 89 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <a href=\"single-product.html\">\r\n");
#nullable restore
#line 91 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                     foreach (var prImage in item.ProductImages.Take(1))
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "025a4a1d2f8cee85e246599938bd54473ddc7a7412492", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5581, "~/assets/img/product/", 5581, 21, true);
#nullable restore
#line 93 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
AddHtmlAttributeValue("", 5602, prImage.ImageUrl, 5602, 17, false);

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
#line 94 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </a>
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
             ");
            WriteLiteral(@"                                                     title=""Add to compare"" class=""icon-shuffle""></span>
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
             ");
            WriteLiteral("                                   <h3 class=\"title\">\r\n                                                    <a href=\"shop-grid-4-column.html\">\r\n                                                        ");
#nullable restore
#line 123 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </a>\r\n                                                </h3>\r\n                                                <div class=\"star-rating\">\r\n");
#nullable restore
#line 127 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                     for (int i = 0; i < item.Star; i++)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <span class=\"ion-ios-star\"></span>\r\n");
#nullable restore
#line 130 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </div>\r\n                                                <div class=\"d-flex align-items-center justify-content-between\">\r\n\r\n");
#nullable restore
#line 134 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                     if (item.DisCountRate > 0)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <h6 class=\"product-price\">\r\n                                                            <del class=\"del\">$ ");
#nullable restore
#line 137 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                                          Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n                                                            <span class=\"onsale\">$ ");
#nullable restore
#line 138 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                                              Write(item.ResultPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                        </h6>\r\n");
#nullable restore
#line 140 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <h6 class=\"product-price\">$ ");
#nullable restore
#line 143 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 144 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    <button class=""pro-btn"" data-toggle=""modal""
                                                            data-target=""#add-to-cart"">
                                                        <i class=""icon-basket""></i>
                                                    </button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- product-list End -->
                                </div>
");
#nullable restore
#line 155 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
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
");
#nullable restore
#line 165 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                         for (int i = 1; i <= ViewBag.PageCount; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"page-item paginationItems\"><a class=\"page-link\" data-page=\"");
#nullable restore
#line 167 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 167 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                                                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 168 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shop\Index.cshtml"
                                            
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </ul>
                                </div>
                            </div>
                        </nav>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 mb-30 order-last"">
                <aside class=""left-sidebar theme1"">
                    <!-- search-filter start -->
                    <div class=""search-filter"">
                        <div class=""check-box-inner pt-0"">
                            <h4 class=""title"">Bags &amp; Shoes</h4>
                        </div>

                    </div>

                    <ul id=""offcanvas-menu2"" class=""blog-ctry-menu"">
                        <li>
                            <a href=""javascript:void(0)"">Shoes</a>
                            <ul class=""category-sub-menu"">
                                <li><a href=""#"">Women Shoes</a></li>
                                <li><a href=""#"">Men Shoes</a></li>
                                <li><");
            WriteLiteral(@"a href=""#"">Boots</a></li>
                                <li><a href=""#"">Casual Shoes</a></li>
                                <li><a href=""#"">Flip Flops</a></li>
                            </ul>

                        </li>
                        <li>
                            <a href=""javascript:void(0)"">Luggage &amp; Bags</a>
                            <ul class=""category-sub-menu"">
                                <li><a href=""#"">Stylish Backpacks</a></li>
                                <li><a href=""#"">Shoulder Bags</a></li>
                                <li><a href=""#"">Crossbody Bags</a></li>
                                <li><a href=""#"">Briefcases</a></li>
                                <li><a href=""#"">Luggage &amp; Travel</a></li>
                            </ul>
                        </li>
                        <li>
                            <a href=""javascript:void(0)"">Accessories</a>
                            <ul class=""category-sub-menu"">
                   ");
            WriteLiteral(@"             <li><a href=""#"">Cosmetic Bags &amp; Cases</a></li>
                                <li><a href=""#"">Wallets &amp; Card Holders</a></li>
                                <li><a href=""#"">Luggage Covers</a></li>
                                <li><a href=""#"">Passport Covers</a></li>
                                <li><a href=""#"">Bag Parts &amp; Accessories</a></li>
                            </ul>
                        </li>
                    </ul>

                    <div class=""search-filter"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "025a4a1d2f8cee85e246599938bd54473ddc7a7425679", async() => {
                WriteLiteral(@"
                            <div class=""check-box-inner mt-10"">
                                <h4 class=""title"">Filter By</h4>
                                <h4 class=""sub-title pt-10"">Categories</h4>
                                <div class=""filter-check-box"">
                                    <input type=""checkbox"" id=""20820"">
                                    <label for=""20820"">Digital Cameras <span>(13)</span></label>
                                </div>
                                <div class=""filter-check-box"">
                                    <input type=""checkbox"" id=""20821"">
                                    <label for=""20821"">Camcorders <span>(13)</span></label>
                                </div>
                                <div class=""filter-check-box"">
                                    <input type=""checkbox"" id=""20822"">
                                    <label for=""20822"">Camera Drones<span>(13)</span></label>
                                </div>
");
                WriteLiteral(@"                            </div>
                            <!-- check-box-inner -->
                            <div class=""check-box-inner mt-10"">
                                <h4 class=""sub-title"">Price</h4>
                                <div class=""price-filter mt-10"">
                                    <div class=""price-slider-amount"">
                                        <input type=""text"" id=""amount"" name=""price"" readonly
                                               placeholder=""Add Your Price"" />
                                    </div>
                                    <div id=""slider-range""></div>
                                </div>
                            </div>
                            <!-- check-box-inner -->
                            <div class=""check-box-inner mt-10"">
                                <h4 class=""sub-title"">color</h4>
                                <div class=""filter-check-box color-grey"">
                                    <input ty");
                WriteLiteral(@"pe=""checkbox"" id=""20826"">
                                    <label for=""20826"">grey <span>(4)</span></label>
                                </div>
                                <div class=""filter-check-box color-white"">
                                    <input type=""checkbox"" id=""20827"">
                                    <label for=""20827"">white <span>(3)</span></label>
                                </div>
                                <div class=""filter-check-box color-black"">
                                    <input type=""checkbox"" id=""20828"">
                                    <label for=""20828"">black <span>(6)</span></label>
                                </div>
                                <div class=""filter-check-box color-camel"">
                                    <input type=""checkbox"" id=""20829"">
                                    <label for=""20829"">camel <span>(2)</span></label>
                                </div>
                            </div>
          ");
                WriteLiteral(@"                  <!-- check-box-inner -->
                            <div class=""check-box-inner mt-10"">
                                <h4 class=""sub-title"">Brand</h4>
                                <div class=""filter-check-box"">
                                    <input type=""checkbox"" id=""20824"">
                                    <label for=""20824"">Graphic Corner<span>(5)</span></label>
                                </div>
                                <div class=""filter-check-box"">
                                    <input type=""checkbox"" id=""20825"">
                                    <label for=""20825"">Studio Design<span>(8)</span></label>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <!--second banner start-->
                    <div class=""banner hover-animation position-relative overflow-hidden"">
                        <a href=""shop-grid-4-column.html"" class=""d-block"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "025a4a1d2f8cee85e246599938bd54473ddc7a7431328", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
