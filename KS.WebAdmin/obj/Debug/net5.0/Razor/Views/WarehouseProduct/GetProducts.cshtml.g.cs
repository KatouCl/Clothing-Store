#pragma checksum "M:\KataStore\KS.WebAdmin\Views\WarehouseProduct\GetProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94e3e12dff1e47b8743263e37a9435ca16d904ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WarehouseProduct_GetProducts), @"mvc.1.0.view", @"/Views/WarehouseProduct/GetProducts.cshtml")]
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
#line 1 "M:\KataStore\KS.WebAdmin\Views\_ViewImports.cshtml"
using KS.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "M:\KataStore\KS.WebAdmin\Views\_ViewImports.cshtml"
using KS.WebAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "M:\KataStore\KS.WebAdmin\Views\_ViewImports.cshtml"
using KS.WebAdmin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "M:\KataStore\KS.WebAdmin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94e3e12dff1e47b8743263e37a9435ca16d904ea", @"/Views/WarehouseProduct/GetProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"447e3f64e1fc1763a915bea7324177c1cea940df", @"/Views/_ViewImports.cshtml")]
    public class Views_WarehouseProduct_GetProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<KS.ViewModels.Warehouse.MangeWarehouseProductItemViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "WarehouseProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "M:\KataStore\KS.WebAdmin\Views\WarehouseProduct\GetProducts.cshtml"
  
    ViewBag.Title = "Склад";
    Layout = "_Layout";
    int warehouseId = ViewBag.warehouseId;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-12 col-lg-12"">
    <div class=""tab"">
        <ul class=""nav nav-tabs"" role=""tablist"">
            <li class=""nav-item"">
                <a class=""nav-link active"" href=""#tab-1"" data-bs-toggle=""tab"" role=""tab"" aria-selected=""true"">Все товары</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""#tab-2"" data-bs-toggle=""tab"" role=""tab"" aria-selected=""false"">Товары склада</a>
            </li>
        </ul>
        <div class=""tab-content"">
            <div class=""tab-pane active"" id=""tab-1"" role=""tabpanel"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94e3e12dff1e47b8743263e37a9435ca16d904ea5137", async() => {
                WriteLiteral("\r\n                    \r\n                    <h4 class=\"tab-title mt-5\">Все товары</h4>\r\n");
#nullable restore
#line 24 "M:\KataStore\KS.WebAdmin\Views\WarehouseProduct\GetProducts.cshtml"
                     if (!Model.Any())
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <h5>Данных нет</h5>\r\n");
#nullable restore
#line 27 "M:\KataStore\KS.WebAdmin\Views\WarehouseProduct\GetProducts.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <table class=""table"">
                            <thead>
                            <tr>
                                <th style=""width:75%;"">Наименование товара</th>
                                <th style=""width: 10%"">Выберите, чтобы добавить</th>
                            </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 38 "M:\KataStore\KS.WebAdmin\Views\WarehouseProduct\GetProducts.cshtml"
                             for (var i = 0; i < Model.Count; i++)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 42 "M:\KataStore\KS.WebAdmin\Views\WarehouseProduct\GetProducts.cshtml"
                                   Write(Html.HiddenFor(x => Model[i].Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 43 "M:\KataStore\KS.WebAdmin\Views\WarehouseProduct\GetProducts.cshtml"
                                   Write(Html.DisplayFor(n => Model[i].Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 46 "M:\KataStore\KS.WebAdmin\Views\WarehouseProduct\GetProducts.cshtml"
                                   Write(Html.CheckBoxFor(c => Model[i].IsCheck, new {@class = "form-check-input"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 49 "M:\KataStore\KS.WebAdmin\Views\WarehouseProduct\GetProducts.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <tr>
                                <td>
                                    <td colspan=""3""></td>
                                    <td>
                                        <button type=""submit"" class=""btn btn-primary"">Добавить выбранные товары</button>
                                    </td>
                                </td>
                            </tr>
                            </tbody>
                        </table>
");
#nullable restore
#line 60 "M:\KataStore\KS.WebAdmin\Views\WarehouseProduct\GetProducts.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-warehouseId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "M:\KataStore\KS.WebAdmin\Views\WarehouseProduct\GetProducts.cshtml"
                                                                                            WriteLiteral(warehouseId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["warehouseId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-warehouseId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["warehouseId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"tab-pane\" id=\"tab-2\" role=\"tabpanel\">\r\n                <h4 class=\"tab-title mt-5\">Товары которые есть на складе</h4>\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<KS.ViewModels.Warehouse.MangeWarehouseProductItemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591