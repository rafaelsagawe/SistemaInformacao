#pragma checksum "C:\Users\rafael.sagawe\Source\Repos\rafaelsagawe\SistemaInformacao\Web\Views\SupImps\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb97372e3d790baae912083cd561adb18c4bba5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SupImps_Index), @"mvc.1.0.view", @"/Views/SupImps/Index.cshtml")]
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
#line 1 "C:\Users\rafael.sagawe\Source\Repos\rafaelsagawe\SistemaInformacao\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rafael.sagawe\Source\Repos\rafaelsagawe\SistemaInformacao\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb97372e3d790baae912083cd561adb18c4bba5b", @"/Views/SupImps/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_SupImps_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web.Models.SupImp>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rafael.sagawe\Source\Repos\rafaelsagawe\SistemaInformacao\Web\Views\SupImps\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">Controle de Estoque dos Toners</h1>\r\n\r\n<p class=\"float-right\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb97372e3d790baae912083cd561adb18c4bba5b4444", async() => {
                WriteLiteral("Novo tipo de toner");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-striped\" id=\"myTable\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\rafael.sagawe\Source\Repos\rafaelsagawe\SistemaInformacao\Web\Views\SupImps\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ModeloToner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\rafael.sagawe\Source\Repos\rafaelsagawe\SistemaInformacao\Web\Views\SupImps\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QtdImpressoas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\rafael.sagawe\Source\Repos\rafaelsagawe\SistemaInformacao\Web\Views\SupImps\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QtdToner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\rafael.sagawe\Source\Repos\rafaelsagawe\SistemaInformacao\Web\Views\SupImps\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Estoque));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\rafael.sagawe\Source\Repos\rafaelsagawe\SistemaInformacao\Web\Views\SupImps\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb97372e3d790baae912083cd561adb18c4bba5b7544", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 38 "C:\Users\rafael.sagawe\Source\Repos\rafaelsagawe\SistemaInformacao\Web\Views\SupImps\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ModeloToner));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\rafael.sagawe\Source\Repos\rafaelsagawe\SistemaInformacao\Web\Views\SupImps\Index.cshtml"
                                           WriteLiteral(item.IdSupImp);

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
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\rafael.sagawe\Source\Repos\rafaelsagawe\SistemaInformacao\Web\Views\SupImps\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.QtdImpressoas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\rafael.sagawe\Source\Repos\rafaelsagawe\SistemaInformacao\Web\Views\SupImps\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.QtdToner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\rafael.sagawe\Source\Repos\rafaelsagawe\SistemaInformacao\Web\Views\SupImps\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Estoque));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    <!-- <a asp-action=\"Edit\" asp-route-id=\"");
#nullable restore
#line 53 "C:\Users\rafael.sagawe\Source\Repos\rafaelsagawe\SistemaInformacao\Web\Views\SupImps\Index.cshtml"
                                                       Write(item.IdSupImp);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Edit</a> |\r\n                    <a asp-action=\"Details\" asp-route-id=\"");
#nullable restore
#line 54 "C:\Users\rafael.sagawe\Source\Repos\rafaelsagawe\SistemaInformacao\Web\Views\SupImps\Index.cshtml"
                                                     Write(item.IdSupImp);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Details</a> |\r\n                    <a asp-action=\"Delete\" asp-route-id=\"");
#nullable restore
#line 55 "C:\Users\rafael.sagawe\Source\Repos\rafaelsagawe\SistemaInformacao\Web\Views\SupImps\Index.cshtml"
                                                    Write(item.IdSupImp);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Delete</a> -->\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 58 "C:\Users\rafael.sagawe\Source\Repos\rafaelsagawe\SistemaInformacao\Web\Views\SupImps\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <!-- script para o funcionamento do DataTables, invoca o ID da tabela myTable
        URL da tradução
        -->

    <script>
        $(document).ready(function () {
            $('#myTable').DataTable({
                ""language"": {
                    ""url"": ""//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Portuguese-Brasil.json""
                }
            });
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web.Models.SupImp>> Html { get; private set; }
    }
}
#pragma warning restore 1591
