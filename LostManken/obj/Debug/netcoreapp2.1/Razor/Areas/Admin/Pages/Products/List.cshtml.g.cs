#pragma checksum "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31a3728745e7aeb79ec4128d13aeb5a985b78546"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Pages_Products_List), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/Products/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Admin/Pages/Products/List.cshtml", typeof(AspNetCore.Areas_Admin_Pages_Products_List), null)]
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
#line 5 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\_ViewImports.cshtml"
using LostManken.Areas.Admin.Pages.Categories;

#line default
#line hidden
#line 6 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\_ViewImports.cshtml"
using LostManken.Areas.Admin.Pages.Products;

#line default
#line hidden
#line 7 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\_ViewImports.cshtml"
using LostManken.Areas.Admin.Pages.Employee;

#line default
#line hidden
#line 8 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\_ViewImports.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31a3728745e7aeb79ec4128d13aeb5a985b78546", @"/Areas/Admin/Pages/Products/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18c45bd6fe732cefe621925b09e75aa0dc24c211", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_Products_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "AddPhotos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(70, 29, true);
            WriteLiteral("\r\n<div style=\"\"></div>\r\n<div>");
            EndContext();
            BeginContext(100, 19, false);
#line 7 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml"
Write(TempData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(119, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            BeginContext(131, 1673, false);
#line 9 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml"
Write(Html

    .Grid(Model.ProductList)
    .Build(columns =>
    {
        columns.Add(model => model.UnitPrice).Titled("Fiyatı");
        columns.Add(model => model.Name).Titled("Kategori Adı");

        columns.Add(model => model.Currency).Titled("Para Birimi");
        columns.Add(model => model.MainPhoto).Titled("Fotoğrafı")
        .Encoded(false).RenderedAs(model => "<img style='max-height:76px;min-height:75px;max-width:51px;min-width:50px' src='" + model.MainPhoto + "'/>").Sortable(false).Filterable(false);
        columns.Add(model => model.MainPhoto).Titled("Action")
        .Encoded(false).RenderedAs(model => $"<a class='btn btn-warning' href='/Admin/Products/Delete/{model.Id}'>Sil</a>").Sortable(false).Filterable(false);

        columns.Add(model => model.MainPhoto).Titled("Action")
                    .Encoded(false).RenderedAs(model => $"<a class='btn btn-primary' href='#AddPhotoModal_{model.Id}' data-toggle='modal'>Fotograf Ekle</a>").Sortable(false).Filterable(false);
        columns.Add(model => model.MainPhoto).Titled("Action")
                    .Encoded(false).RenderedAs(model => $"<a class='btn btn-primary' href='#EditPhotoModal_{model.Id}' data-toggle='modal'>Fotograf Güncelle</a>").Sortable(false).Filterable(false);
        columns.Add(model => model.MainPhoto).Titled("Action")
                    .Encoded(false).RenderedAs(model => $"<a class='btn btn-primary' href='/Admin/Products/Edit/{model.Id}' data-toggle='modal'>Ürün Güncelle</a>").Sortable(false).Filterable(false);

    })
    .Empty("No data found")
    .Filterable()
    .Sortable()
    .Pageable(pager => { pager.PagesToDisplay = 10; })


);

#line default
#line hidden
            EndContext();
            BeginContext(1805, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 40 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml"
 foreach (var item in Model.ProductList)
{

#line default
#line hidden
            BeginContext(1856, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1864, "\"", 1891, 2);
            WriteAttributeValue("", 1869, "AddPhotoModal_", 1869, 14, true);
#line 42 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml"
WriteAttributeValue("", 1883, item.Id, 1883, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1892, 327, true);
            WriteLiteral(@" class=""modal fade"" role=""dialog"">

        <div class=""modal-dialog"">

            Modal content
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                    <h4 class=""modal-title"">");
            EndContext();
            BeginContext(2220, 9, false);
#line 50 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml"
                                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2229, 114, true);
            WriteLiteral(" - Fotoğrafları</h4>\r\n                </div>\r\n                <div class=\"modal-body\">\r\n\r\n\r\n\r\n                    ");
            EndContext();
            BeginContext(2343, 721, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "602a9092009b47558e9ce8162e2111f0", async() => {
                BeginContext(2393, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 58 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml"
                          
                            Model.SelectedProductId = item.Id;
                        

#line default
#line hidden
                BeginContext(2516, 61, true);
                WriteLiteral("\r\n                        <div>\r\n                            ");
                EndContext();
                BeginContext(2577, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "49ff1216279a4b8992582395e681d19b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 63 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectedProductId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2628, 164, true);
                WriteLiteral("\r\n                            &nbsp;&nbsp;&nbsp;\r\n\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
                EndContext();
                BeginContext(2792, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0b00e5d171d44d83b9a63c788c39766e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("multiple", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#line 69 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.files);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2857, 60, true);
                WriteLiteral("\r\n                        </div>\r\n\r\n                        ");
                EndContext();
                BeginContext(2917, 116, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d473b2cc19c44bb399330654ec54ac22", async() => {
                    BeginContext(2992, 32, true);
                    WriteLiteral("<i class=\"fa fa-save\">Kaydet</i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3033, 24, true);
                WriteLiteral("\r\n\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3064, 80, true);
            WriteLiteral("\r\n\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 82 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml"
}

#line default
#line hidden
            BeginContext(3147, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
#line 87 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml"
 foreach (var item in Model.ProductList)
{

#line default
#line hidden
            BeginContext(3200, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3208, "\"", 3236, 2);
            WriteAttributeValue("", 3213, "EditPhotoModal_", 3213, 15, true);
#line 89 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml"
WriteAttributeValue("", 3228, item.Id, 3228, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3237, 327, true);
            WriteLiteral(@" class=""modal fade"" role=""dialog"">

        <div class=""modal-dialog"">

            Modal content
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                    <h4 class=""modal-title"">");
            EndContext();
            BeginContext(3565, 9, false);
#line 97 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml"
                                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3574, 117, true);
            WriteLiteral(" - Fotoğrafları</h4>\r\n                </div>\r\n                <div class=\"modal-body\">\r\n\r\n                    <div>\r\n");
            EndContext();
#line 102 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml"
                         foreach (var photo_item in item.Photos)
                        {

#line default
#line hidden
            BeginContext(3784, 33, true);
            WriteLiteral("                            <span");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3817, "\"", 3840, 2);
            WriteAttributeValue("", 3822, "img_", 3822, 4, true);
#line 104 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml"
WriteAttributeValue("", 3826, photo_item.Id, 3826, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3841, 93, true);
            WriteLiteral(">\r\n                                <img style=\"width:100px;height:100px; margin-bottom:20px;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3934, "\"", 3959, 1);
#line 105 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml"
WriteAttributeValue("", 3940, photo_item.FileUrl, 3940, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3960, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(4027, 42, true);
            WriteLiteral("                                <a href=\"\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4069, "\"", 4103, 3);
            WriteAttributeValue("", 4079, "Delete(\'", 4079, 8, true);
#line 107 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml"
WriteAttributeValue("", 4087, photo_item.Id, 4087, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 4101, "\')", 4101, 2, true);
            EndWriteAttribute();
            BeginContext(4104, 73, true);
            WriteLiteral("  style=\"font-size: 25px;\"> X </a>\r\n                            </span>\r\n");
            EndContext();
#line 109 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml"

                        }

#line default
#line hidden
            BeginContext(4206, 52, true);
            WriteLiteral("                    </div>\r\n\r\n\r\n                    ");
            EndContext();
            BeginContext(4258, 721, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb329c04de1f4df1a892097cfc69c346", async() => {
                BeginContext(4308, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 116 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml"
                          
                            Model.SelectedProductId = item.Id;
                        

#line default
#line hidden
                BeginContext(4431, 61, true);
                WriteLiteral("\r\n                        <div>\r\n                            ");
                EndContext();
                BeginContext(4492, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c02c1d9f08e8430e9eae1aca58f22581", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 121 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectedProductId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4543, 164, true);
                WriteLiteral("\r\n                            &nbsp;&nbsp;&nbsp;\r\n\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
                EndContext();
                BeginContext(4707, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d5ccad65f7fa444893d93548941e61df", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("multiple", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#line 127 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.files);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4772, 60, true);
                WriteLiteral("\r\n                        </div>\r\n\r\n                        ");
                EndContext();
                BeginContext(4832, 116, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d636c1ff28b5480fa0bb3c38601893bf", async() => {
                    BeginContext(4907, 32, true);
                    WriteLiteral("<i class=\"fa fa-save\">Kaydet</i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4948, 24, true);
                WriteLiteral("\r\n\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4979, 80, true);
            WriteLiteral("\r\n\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 140 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Products\List.cshtml"
}

#line default
#line hidden
            BeginContext(5062, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(5082, 582, true);
                WriteLiteral(@"

    <script>
        function Delete(photo_id) {
         
            
            $.ajax({
                url: '/Product/DeletePhoto?PhotoId=' + photo_id,
                method: 'GET',
                success: function (response) {
                    alert(response);
                    $('#img_' + photo_id).fadeOut();

                },
                error: function (err) {
                    console.log(err);
                }
            })
            return false;
            //ajax
            //alert(photo_id);
        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(5667, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LostManken.Areas.Admin.Pages.Products.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LostManken.Areas.Admin.Pages.Products.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LostManken.Areas.Admin.Pages.Products.ListModel>)PageContext?.ViewData;
        public LostManken.Areas.Admin.Pages.Products.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591