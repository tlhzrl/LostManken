#pragma checksum "C:\Users\muham\Source\Repos\LostManken\LostManken\Pages\Product\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03d9a7cb4cdb0f768dfa83be7b136310044a5b2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Product_ProductDetail), @"mvc.1.0.razor-page", @"/Pages/Product/ProductDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Product/ProductDetail.cshtml", typeof(AspNetCore.Pages_Product_ProductDetail), @"{id}")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03d9a7cb4cdb0f768dfa83be7b136310044a5b2b", @"/Pages/Product/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"826e44d16a9132286586eb2f29e13682c5acb0ce", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Product_ProductDetail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\muham\Source\Repos\LostManken\LostManken\Pages\Product\ProductDetail.cshtml"
  
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(106, 325, true);
            WriteLiteral(@"
<link href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js""></script>
<script src=""https://code.jquery.com/jquery-1.11.1.min.js""></script>


<!DOCTYPE html>
<html lang=""en"">
");
            EndContext();
            BeginContext(431, 346, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcdbfc3a759c447eb9ea0f666aa8ab17", async() => {
                BeginContext(437, 333, true);
                WriteLiteral(@"

    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <title>eCommerce Product Detail</title>
    <link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:400,700"" rel=""stylesheet"">

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(777, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(781, 4008, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce11be9a092149c7b615c18bbdcac2cf", async() => {
                BeginContext(787, 1616, true);
                WriteLiteral(@"

    <div class=""bradcam_area breadcam_bg_3"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xl-12"">
                    <div class=""bradcam_text"">
                        <h3>Contact Us</h3>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""modal fade product-modal"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">

                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    Ürünü almak istiyorsanız sizi iletişim sayfamıza yönlendiriyoruz.
         ");
                WriteLiteral(@"       </div>
                <div class=""modal-footer"">
                    <a class=""btn btn-secondary"" data-dismiss=""modal"">Gitme</a>
                    <a href=""http://localhost:50157/Contact/Contact"" type=""button"" class=""btn btn-primary"">Git</a>
                </div>
            </div>
        </div>
    </div>

    <div class=""container"">
        <div class=""card"">
            <div class=""container-fliud"">
                <div class=""wrapper row"">
                    <div class=""preview col-md-6"">

                        <div class=""preview-pic tab-content"">

");
                EndContext();
#line 66 "C:\Users\muham\Source\Repos\LostManken\LostManken\Pages\Product\ProductDetail.cshtml"
                               int i = 1; 

#line default
#line hidden
                BeginContext(2448, 77, true);
                WriteLiteral("\r\n\r\n                            <div class=\"tab-pane active\" id=\"pic-0)\"><img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2525, "\"", 2555, 1);
#line 69 "C:\Users\muham\Source\Repos\LostManken\LostManken\Pages\Product\ProductDetail.cshtml"
WriteAttributeValue("", 2531, Model.Product.MainPhoto, 2531, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2556, 13, true);
                WriteLiteral(" /></div>\r\n\r\n");
                EndContext();
#line 71 "C:\Users\muham\Source\Repos\LostManken\LostManken\Pages\Product\ProductDetail.cshtml"
                             foreach (var item in Model.Product.Photos)
                            {


#line default
#line hidden
                BeginContext(2675, 53, true);
                WriteLiteral("                                <div class=\"tab-pane\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2728, "\"", 2752, 2);
                WriteAttributeValue("", 2733, "pic-", 2733, 4, true);
#line 74 "C:\Users\muham\Source\Repos\LostManken\LostManken\Pages\Product\ProductDetail.cshtml"
WriteAttributeValue("", 2737, i.ToString(), 2737, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2753, 5, true);
                WriteLiteral("><img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2758, "\"", 2777, 1);
#line 74 "C:\Users\muham\Source\Repos\LostManken\LostManken\Pages\Product\ProductDetail.cshtml"
WriteAttributeValue("", 2764, item.FileUrl, 2764, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2778, 11, true);
                WriteLiteral(" /></div>\r\n");
                EndContext();
#line 75 "C:\Users\muham\Source\Repos\LostManken\LostManken\Pages\Product\ProductDetail.cshtml"

                                i = i + 1;
                            }

#line default
#line hidden
                BeginContext(2866, 111, true);
                WriteLiteral("\r\n\r\n\r\n                        </div>\r\n\r\n                        <ul class=\"preview-thumbnail nav nav-tabs\">\r\n\r\n");
                EndContext();
#line 85 "C:\Users\muham\Source\Repos\LostManken\LostManken\Pages\Product\ProductDetail.cshtml"
                               i = 1;
                            

#line default
#line hidden
                BeginContext(3047, 78, true);
                WriteLiteral("                            <li><a data-target=\"#pic-0\" data-toggle=\"tab\"><img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3125, "\"", 3155, 1);
#line 87 "C:\Users\muham\Source\Repos\LostManken\LostManken\Pages\Product\ProductDetail.cshtml"
WriteAttributeValue("", 3131, Model.Product.MainPhoto, 3131, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3156, 14, true);
                WriteLiteral(" /></a></li>\r\n");
                EndContext();
#line 88 "C:\Users\muham\Source\Repos\LostManken\LostManken\Pages\Product\ProductDetail.cshtml"
                             foreach (var item in Model.Product.Photos)
                            {

#line default
#line hidden
                BeginContext(3274, 57, true);
                WriteLiteral("                                <li><a data-target=\"#pic-");
                EndContext();
                BeginContext(3333, 12, false);
#line 90 "C:\Users\muham\Source\Repos\LostManken\LostManken\Pages\Product\ProductDetail.cshtml"
                                                     Write(i.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(3346, 24, true);
                WriteLiteral("\" data-toggle=\"tab\"><img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3370, "\"", 3389, 1);
#line 90 "C:\Users\muham\Source\Repos\LostManken\LostManken\Pages\Product\ProductDetail.cshtml"
WriteAttributeValue("", 3376, item.FileUrl, 3376, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3390, 14, true);
                WriteLiteral(" /></a></li>\r\n");
                EndContext();
#line 91 "C:\Users\muham\Source\Repos\LostManken\LostManken\Pages\Product\ProductDetail.cshtml"
                                i = i + 1;
                            }

#line default
#line hidden
                BeginContext(3479, 163, true);
                WriteLiteral("                        </ul>\r\n\r\n                    </div>\r\n                    <div class=\"details col-md-6\">\r\n                        <h3 class=\"product-title\">");
                EndContext();
                BeginContext(3643, 18, false);
#line 97 "C:\Users\muham\Source\Repos\LostManken\LostManken\Pages\Product\ProductDetail.cshtml"
                                             Write(Model.Product.Name);

#line default
#line hidden
                EndContext();
                BeginContext(3661, 72, true);
                WriteLiteral("</h3>\r\n\r\n\r\n\r\n                        <p class=\"vote\"><dt>Açıklama:</dt> ");
                EndContext();
                BeginContext(3734, 19, false);
#line 101 "C:\Users\muham\Source\Repos\LostManken\LostManken\Pages\Product\ProductDetail.cshtml"
                                                      Write(Model.Product.Notes);

#line default
#line hidden
                EndContext();
                BeginContext(3753, 206, true);
                WriteLiteral("  </p>\r\n\r\n                        <h5 class=\"colors\">\r\n                            <dl class=\"param param-feature\">\r\n                                <dt>Özellikler</dt>\r\n                                <dd>");
                EndContext();
                BeginContext(3960, 35, false);
#line 106 "C:\Users\muham\Source\Repos\LostManken\LostManken\Pages\Product\ProductDetail.cshtml"
                               Write(Html.Raw(@Model.Product.Properties));

#line default
#line hidden
                EndContext();
                BeginContext(3995, 237, true);
                WriteLiteral("</dd>\r\n                            </dl>\r\n                        </h5>\r\n\r\n                        <h5 class=\"sizes\">\r\n                            Stok:\r\n                            <span class=\"size\" data-toggle=\"tooltip\" title=\"small\">");
                EndContext();
                BeginContext(4233, 19, false);
#line 112 "C:\Users\muham\Source\Repos\LostManken\LostManken\Pages\Product\ProductDetail.cshtml"
                                                                              Write(Model.Product.Stock);

#line default
#line hidden
                EndContext();
                BeginContext(4252, 105, true);
                WriteLiteral(" Adet </span>\r\n\r\n                        </h5>\r\n\r\n                        <h4 class=\"price\">Fiyat: <span>");
                EndContext();
                BeginContext(4358, 23, false);
#line 116 "C:\Users\muham\Source\Repos\LostManken\LostManken\Pages\Product\ProductDetail.cshtml"
                                                  Write(Model.Product.UnitPrice);

#line default
#line hidden
                EndContext();
                BeginContext(4381, 401, true);
                WriteLiteral(@"</span></h4>

                        <div class=""action"">
                            <a href=""#"" class=""btn btn-lg btn-primary text-uppercase"" type=""button"" data-toggle=""modal"" data-target=""#exampleModalCenter""> Buy now </a>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />
    <br />
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4789, 19, true);
            WriteLiteral("\r\n\r\n\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LostManken.ProductDetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LostManken.ProductDetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LostManken.ProductDetailModel>)PageContext?.ViewData;
        public LostManken.ProductDetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
