#pragma checksum "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Employee\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f60685e7c69e33d78028d76f286df06ecd266ba6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Pages_Employee_Detail), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/Employee/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Admin/Pages/Employee/Detail.cshtml", typeof(AspNetCore.Areas_Admin_Pages_Employee_Detail), @"{id}")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f60685e7c69e33d78028d76f286df06ecd266ba6", @"/Areas/Admin/Pages/Employee/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18c45bd6fe732cefe621925b09e75aa0dc24c211", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_Employee_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(79, 391, true);
            WriteLiteral(@"    <table class=""table table-bordered table-striped"" style=""width:100%"">
        <thead>
            <tr>
                <th>Müşteri adı</th>
                <th>Müşteri soyadı</th>
                <th>E-Mail</th>
                <th>Adres</th>
                <th>Telefon numarası</th>
            </tr>
        </thead>

        <tbody>
            <tr>
                <td>");
            EndContext();
            BeginContext(471, 27, false);
#line 18 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Employee\Detail.cshtml"
               Write(Model.Employee.CustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(498, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(526, 30, false);
#line 19 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Employee\Detail.cshtml"
               Write(Model.Employee.CustomerSurname);

#line default
#line hidden
            EndContext();
            BeginContext(556, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(584, 28, false);
#line 20 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Employee\Detail.cshtml"
               Write(Model.Employee.CustomerEMail);

#line default
#line hidden
            EndContext();
            BeginContext(612, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(640, 30, false);
#line 21 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Employee\Detail.cshtml"
               Write(Model.Employee.CustomerAddress);

#line default
#line hidden
            EndContext();
            BeginContext(670, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(698, 26, false);
#line 22 "C:\Users\muham\Source\Repos\LostManken\LostManken\Areas\Admin\Pages\Employee\Detail.cshtml"
               Write(Model.Employee.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(724, 62, true);
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n\r\n        </tbody>\r\n\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LostManken.Areas.Admin.Pages.Employee.DetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LostManken.Areas.Admin.Pages.Employee.DetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LostManken.Areas.Admin.Pages.Employee.DetailModel>)PageContext?.ViewData;
        public LostManken.Areas.Admin.Pages.Employee.DetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591