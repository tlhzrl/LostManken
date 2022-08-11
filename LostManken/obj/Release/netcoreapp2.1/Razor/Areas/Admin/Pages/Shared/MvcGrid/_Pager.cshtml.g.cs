#pragma checksum "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af413a1ddbf7b9c229db113e68d211ed2e5d0e75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Pages_Shared_MvcGrid__Pager), @"mvc.1.0.view", @"/Areas/Admin/Pages/Shared/MvcGrid/_Pager.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Pages/Shared/MvcGrid/_Pager.cshtml", typeof(AspNetCore.Areas_Admin_Pages_Shared_MvcGrid__Pager))]
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
#line 1 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af413a1ddbf7b9c229db113e68d211ed2e5d0e75", @"/Areas/Admin/Pages/Shared/MvcGrid/_Pager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18c45bd6fe732cefe621925b09e75aa0dc24c211", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_Shared_MvcGrid__Pager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IGridPager>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
  
    Int32 totalPages = Model.TotalPages;
    Int32 currentPage = Model.CurrentPage;
    Int32 firstDisplayPage = Model.FirstDisplayPage;

#line default
#line hidden
            BeginContext(195, 6, true);
            WriteLiteral("\r\n<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 201, "\"", 241, 2);
            WriteAttributeValue("", 209, "mvc-grid-pager", 209, 14, true);
#line 9 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
WriteAttributeValue(" ", 223, Model.CssClasses, 224, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(242, 23, true);
            WriteLiteral(" data-show-page-sizes=\"");
            EndContext();
            BeginContext(266, 19, false);
#line 9 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
                                                               Write(Model.ShowPageSizes);

#line default
#line hidden
            EndContext();
            BeginContext(285, 4, true);
            WriteLiteral("\">\r\n");
            EndContext();
#line 10 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
     if (totalPages > 0)
    {
        if (currentPage > 1)
        {

#line default
#line hidden
            BeginContext(363, 110, true);
            WriteLiteral("            <button type=\"button\" data-page=\"1\">&#171;</button>\r\n            <button type=\"button\" data-page=\"");
            EndContext();
            BeginContext(475, 15, false);
#line 15 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
                                         Write(currentPage - 1);

#line default
#line hidden
            EndContext();
            BeginContext(491, 20, true);
            WriteLiteral("\">&#8249;</button>\r\n");
            EndContext();
#line 16 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(547, 165, true);
            WriteLiteral("            <button type=\"button\" class=\"disabled\" tabindex=\"-1\">&#171;</button>\r\n            <button type=\"button\" class=\"disabled\" tabindex=\"-1\">&#8249;</button>\r\n");
            EndContext();
#line 21 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
        }
        for (Int32 page = firstDisplayPage; page <= totalPages && page < firstDisplayPage + Model.PagesToDisplay; page++)
        {
            if (page == currentPage)
            {

#line default
#line hidden
            BeginContext(910, 64, true);
            WriteLiteral("                <button type=\"button\" class=\"active\" data-page=\"");
            EndContext();
            BeginContext(976, 4, false);
#line 26 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
                                                            Write(page);

#line default
#line hidden
            EndContext();
            BeginContext(981, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(985, 4, false);
#line 26 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
                                                                     Write(page);

#line default
#line hidden
            EndContext();
            BeginContext(990, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
#line 27 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1049, 49, true);
            WriteLiteral("                <button type=\"button\" data-page=\"");
            EndContext();
            BeginContext(1100, 4, false);
#line 30 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
                                             Write(page);

#line default
#line hidden
            EndContext();
            BeginContext(1105, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(1109, 4, false);
#line 30 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
                                                      Write(page);

#line default
#line hidden
            EndContext();
            BeginContext(1114, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
#line 31 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
            }
        }
        if (currentPage < totalPages)
        {

#line default
#line hidden
            BeginContext(1201, 45, true);
            WriteLiteral("            <button type=\"button\" data-page=\"");
            EndContext();
            BeginContext(1248, 15, false);
#line 35 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
                                         Write(currentPage + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1264, 65, true);
            WriteLiteral("\">&#8250;</button>\r\n            <button type=\"button\" data-page=\"");
            EndContext();
            BeginContext(1330, 10, false);
#line 36 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
                                        Write(totalPages);

#line default
#line hidden
            EndContext();
            BeginContext(1340, 19, true);
            WriteLiteral("\">&#187;</button>\r\n");
            EndContext();
#line 37 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1395, 165, true);
            WriteLiteral("            <button type=\"button\" class=\"disabled\" tabindex=\"-1\">&#8250;</button>\r\n            <button type=\"button\" class=\"disabled\" tabindex=\"-1\">&#187;</button>\r\n");
            EndContext();
#line 42 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
        }
        if (Model.ShowPageSizes)
        {

#line default
#line hidden
            BeginContext(1616, 47, true);
            WriteLiteral("            <div class=\"mvc-grid-page-sizes\">\r\n");
            EndContext();
#line 46 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
                 if (Model.PageSizes.Count > 0)
                {

#line default
#line hidden
            BeginContext(1731, 58, true);
            WriteLiteral("                    <select class=\"mvc-grid-pager-rows\">\r\n");
            EndContext();
#line 49 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
                         foreach (KeyValuePair<Int32, String> size in Model.PageSizes)
                        {
                            if (Model.RowsPerPage == size.Key)
                            {

#line default
#line hidden
            BeginContext(1999, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2031, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88f49197a0f24db295dcc355ab640651", async() => {
                BeginContext(2067, 10, false);
#line 53 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
                                                              Write(size.Value);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
                                   WriteLiteral(size.Key);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2086, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 54 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2184, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2216, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c145ec721a904032bb00413cc25259af", async() => {
                BeginContext(2243, 10, false);
#line 57 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
                                                     Write(size.Value);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
                                   WriteLiteral(size.Key);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2262, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 58 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(2322, 31, true);
            WriteLiteral("                    </select>\r\n");
            EndContext();
#line 61 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2413, 54, true);
            WriteLiteral("                    <input class=\"mvc-grid-pager-rows\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2467, "\"", 2493, 1);
#line 64 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
WriteAttributeValue("", 2475, Model.RowsPerPage, 2475, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2494, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 65 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
                }

#line default
#line hidden
            BeginContext(2518, 20, true);
            WriteLiteral("            </div>\r\n");
            EndContext();
#line 67 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2574, 60, true);
            WriteLiteral("            <input class=\"mvc-grid-pager-rows\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2634, "\"", 2660, 1);
#line 70 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
WriteAttributeValue("", 2642, Model.RowsPerPage, 2642, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2661, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 71 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(2701, 56, true);
            WriteLiteral("        <input class=\"mvc-grid-pager-rows\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2757, "\"", 2783, 1);
#line 75 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
WriteAttributeValue("", 2765, Model.RowsPerPage, 2765, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2784, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 76 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Shared\MvcGrid\_Pager.cshtml"
    }

#line default
#line hidden
            BeginContext(2796, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IGridPager> Html { get; private set; }
    }
}
#pragma warning restore 1591
