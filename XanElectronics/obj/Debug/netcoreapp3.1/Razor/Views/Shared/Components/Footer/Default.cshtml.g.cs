#pragma checksum "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50cf899c1e98b1033cc80f6c0aa1795f4a0617fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50cf899c1e98b1033cc80f6c0aa1795f4a0617fe", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"644cd9a76a4ae02722074aa55e401440db82eec1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("footer logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_partialSubscribe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shared\Components\Footer\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <footer class=""bg-light theme3 position-relative"">
        <!-- footer bottom start -->
        <div class=""footer-bottom pt-80 pb-30"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12 col-md-6 col-lg-4 mb-30"">
                        <div class=""footer-widget mx-w-400"">
                            <div class=""footer-logo mb-35"">
                                <a href=""index.html"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "50cf899c1e98b1033cc80f6c0aa1795f4a0617fe4707", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 546, "~/assets/img/logo/", 546, 18, true);
#nullable restore
#line 15 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shared\Components\Footer\Default.cshtml"
AddHtmlAttributeValue("", 564, Model.FooterLogoUrl, 564, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </a>
                            </div>
                            <p class=""text mb-30"">
                                We are a team of designers and developers that create high quality
                                Magento, Prestashop, Opencart.
                            </p>
                            <div class=""address-widget mb-30"">
                                <div class=""media"">
                                    <span class=""address-icon mr-3"">
                                        <img src=""assets/img/icon/phone3.png"" alt=""phone"">
                                    </span>
                                    <div class=""media-body"">
                                        <p class=""help-text text-uppercase"">NEED HELP?</p>
                                        <h4 class=""title text-dark"">");
#nullable restore
#line 29 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shared\Components\Footer\Default.cshtml"
                                                               Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                    </div>
                                </div>
                            </div>

                            <div class=""social-network"">
                                <ul class=""d-flex"">
                                    <li>
                                        <a");
            BeginWriteAttribute("href", " href=\"", 1812, "\"", 1834, 1);
#nullable restore
#line 37 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 1819, Model.Facebook, 1819, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"">
                                            <span class=""icon-social-facebook""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a");
            BeginWriteAttribute("href", " href=\"", 2115, "\"", 2136, 1);
#nullable restore
#line 42 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 2122, Model.Twitter, 2122, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"">
                                            <span class=""icon-social-twitter""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a");
            BeginWriteAttribute("href", " href=\"", 2416, "\"", 2437, 1);
#nullable restore
#line 47 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 2423, Model.Youtube, 2423, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"">
                                            <span class=""icon-social-youtube""></span>
                                        </a>
                                    </li>
                                    <li class=""mr-0"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 2730, "\"", 2753, 1);
#nullable restore
#line 52 "C:\Users\User\Desktop\XanElectronics\XanElectronics\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 2737, Model.Instagram, 2737, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"">
                                            <span class=""icon-social-instagram""></span>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class=""col-12 col-md-6 col-lg-2 mb-30"">
                        <div class=""footer-widget"">
                            <div class=""border-bottom cbb1 mb-25"">
                                <div class=""section-title pb-20"">
                                    <h2 class=""title text-dark text-uppercase"">Information</h2>
                                </div>
                            </div>
                            <!-- footer-menu start -->
                            <ul class=""footer-menu"">
                                <li><a href=""#"">Delivery</a></li>
                                <li><a href=""about-us.html"">About us</a></li>
         ");
            WriteLiteral(@"                       <li><a href=""#"">Secure payment</a></li>
                                <li><a href=""contact.html"">Contact us</a></li>
                                <li><a href=""#"">Sitemap</a></li>
                                <li><a href=""#"">Stores</a></li>
                            </ul>
                            <!-- footer-menu end -->
                        </div>
                    </div>
                    <div class=""col-12 col-md-6 col-lg-2 mb-30"">
                        <div class=""footer-widget"">
                            <div class=""border-bottom cbb1 mb-25"">
                                <div class=""section-title pb-20"">
                                    <h2 class=""title text-dark text-uppercase"">Custom Links</h2>
                                </div>
                            </div>
                            <!-- footer-menu start -->
                            <ul class=""footer-menu"">
                                <li><a href=""#"">Legal Notice</");
            WriteLiteral(@"a></li>
                                <li><a href=""#"">Prices drop</a></li>

                                <li><a href=""#"">New products</a></li>

                                <li><a href=""#"">Best sales</a></li>

                                <li><a href=""login.html"">Login</a></li>

                                <li><a href=""myaccount.html"">My account</a></li>
                            </ul>
                            <!-- footer-menu end -->
                        </div>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "50cf899c1e98b1033cc80f6c0aa1795f4a0617fe12932", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <!-- footer bottom end -->
        <!-- coppy-right start -->
        <div class=""coppy-right pb-80"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12 col-md-6 col-lg-4"">
                        <div class=""text-left"">
                            <p class=""mb-3 mb-md-0"">
                                Copyright &copy; <a href=""https://hasthemes.com/"">HasThemes</a>. All
                                Rights Reserved
                            </p>
                        </div>
                    </div>
                    <div class=""col-12 col-md-6 col-lg-8"">
                        <div class=""text-left"">
                            <img src=""assets/img/payment/1.png"" alt=""img"">
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- coppy-right end -->
    </footer>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bio> Html { get; private set; }
    }
}
#pragma warning restore 1591
