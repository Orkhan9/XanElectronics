#pragma checksum "/home/orkhan/my projects/XanElectronics/XanElectronics/Areas/Admin/Views/Product/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "868e12185d8df93d5bb9eba7b0f952867d56ba44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Detail.cshtml")]
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
#line 1 "/home/orkhan/my projects/XanElectronics/XanElectronics/Areas/Admin/Views/_ViewImports.cshtml"
using XanElectronics.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/orkhan/my projects/XanElectronics/XanElectronics/Areas/Admin/Views/_ViewImports.cshtml"
using XanElectronics.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"868e12185d8df93d5bb9eba7b0f952867d56ba44", @"/Areas/Admin/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"644cd9a76a4ae02722074aa55e401440db82eec1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/orkhan/my projects/XanElectronics/XanElectronics/Areas/Admin/Views/Product/Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "_adminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 7 "/home/orkhan/my projects/XanElectronics/XanElectronics/Areas/Admin/Views/Product/Detail.cshtml"
         foreach (var item in Model.ProductImages)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"mr-2 mt-3\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "868e12185d8df93d5bb9eba7b0f952867d56ba445210", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 233, "~/assets/img/product/", 233, 21, true);
#nullable restore
#line 10 "/home/orkhan/my projects/XanElectronics/XanElectronics/Areas/Admin/Views/Product/Detail.cshtml"
AddHtmlAttributeValue("", 254, item.ImageUrl, 254, 14, false);

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
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 12 "/home/orkhan/my projects/XanElectronics/XanElectronics/Areas/Admin/Views/Product/Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"row mt-5\">\r\n    <div class=\"col-2\">\r\n        <h6>Ad</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
#nullable restore
#line 21 "/home/orkhan/my projects/XanElectronics/XanElectronics/Areas/Admin/Views/Product/Detail.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>Yeni</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
#nullable restore
#line 31 "/home/orkhan/my projects/XanElectronics/XanElectronics/Areas/Admin/Views/Product/Detail.cshtml"
       Write(Model.IsNew);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>Secilmis</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
#nullable restore
#line 39 "/home/orkhan/my projects/XanElectronics/XanElectronics/Areas/Admin/Views/Product/Detail.cshtml"
       Write(Model.IsFeatured);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>Kateqoriya</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
#nullable restore
#line 47 "/home/orkhan/my projects/XanElectronics/XanElectronics/Areas/Admin/Views/Product/Detail.cshtml"
       Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>Brend</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
#nullable restore
#line 55 "/home/orkhan/my projects/XanElectronics/XanElectronics/Areas/Admin/Views/Product/Detail.cshtml"
       Write(Model.Brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-2\">\r\n        <h6>Qiymet</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
#nullable restore
#line 63 "/home/orkhan/my projects/XanElectronics/XanElectronics/Areas/Admin/Views/Product/Detail.cshtml"
       Write(Model.Price.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Azn</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>Endirim</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
#nullable restore
#line 71 "/home/orkhan/my projects/XanElectronics/XanElectronics/Areas/Admin/Views/Product/Detail.cshtml"
       Write(Model.DisCountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</p>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-2\">\r\n    <div class=\"col-2\">\r\n        <h6>YekunQiymet</h6>\r\n    </div>\r\n    <div class=\"col-4\">\r\n        <p> ");
#nullable restore
#line 79 "/home/orkhan/my projects/XanElectronics/XanElectronics/Areas/Admin/Views/Product/Detail.cshtml"
       Write(Model.ResultPrice.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Azn</p>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row mt-3\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "868e12185d8df93d5bb9eba7b0f952867d56ba4410402", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
