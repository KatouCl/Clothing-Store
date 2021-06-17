#pragma checksum "M:\KataStore\KS.WEB\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee20e1e0e79d6517f618e033da632eb2023920db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#line 1 "M:\KataStore\KS.WEB\Areas\Admin\Views\_ViewImports.cshtml"
using KS.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "M:\KataStore\KS.WEB\Areas\Admin\Views\_ViewImports.cshtml"
using KS.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "M:\KataStore\KS.WEB\Areas\Admin\Views\_ViewImports.cshtml"
using KS.WEB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "M:\KataStore\KS.WEB\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee20e1e0e79d6517f618e033da632eb2023920db", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a3ffd2718f35aba8b71860d98af4838f2ae35c3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KS.ViewModels.Order.OrderHomeVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("32"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("32"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle my-n1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "M:\KataStore\KS.WEB\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Главная страница";
    Layout = "_AdminLayout";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""wrapper"">
    <div class=""main"">
        <div class=""container-fluid p-0"">
            <div class=""row"">
                <div class=""col-xl-6 col-xxl-5 d-flex"">
                    <div class=""w-100"">
                        <div class=""row"">
                            <div class=""col-sm-6"">
                                <div class=""card"">
                                    <div class=""card-body"">
                                        <h5 class=""card-title mb-4"">Проданных товаров</h5>
                                        <h1 class=""mt-1 mb-3"">");
#nullable restore
#line 19 "M:\KataStore\KS.WEB\Areas\Admin\Views\Home\Index.cshtml"
                                                         Write(ViewBag.GoodsSold);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                                        <div class=\"mb-1\">\r\n");
            WriteLiteral(@"                                            <span class=""text-muted"">За все время</span>
                                        </div>
                                    </div>
                                </div>
                                <div class=""card"">
                                    <div class=""card-body"">
                                        <h5 class=""card-title mb-4"">Заработано денег</h5>
                                        <h1 class=""mt-1 mb-3"">₽ ");
#nullable restore
#line 29 "M:\KataStore\KS.WEB\Areas\Admin\Views\Home\Index.cshtml"
                                                           Write(ViewBag.MoneyEarned);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                                        <div class=\"mb-1\">\r\n");
            WriteLiteral(@"                                            <span class=""text-muted"">За все время</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-sm-6"">
                                <div class=""card"">
                                    <div class=""card-body"">
                                        <h5 class=""card-title mb-4"">Пользователей</h5>
                                        <h1 class=""mt-1 mb-3"">");
#nullable restore
#line 41 "M:\KataStore\KS.WEB\Areas\Admin\Views\Home\Index.cshtml"
                                                         Write(ViewBag.Users);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                                        <div class=\"mb-1\">\r\n");
            WriteLiteral(@"                                            <span class=""text-muted"">За все время</span>
                                        </div>
                                    </div>
                                </div>
                                <div class=""card"">
                                    <div class=""card-body"">
                                        <h5 class=""card-title mb-4"">Заказы</h5>
                                        <h1 class=""mt-1 mb-3"">");
#nullable restore
#line 51 "M:\KataStore\KS.WEB\Areas\Admin\Views\Home\Index.cshtml"
                                                         Write(ViewBag.Orders);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                                        <div class=\"mb-1\">\r\n");
            WriteLiteral(@"                                            <span class=""text-muted"">За все время</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col-xl-6 col-xxl-7"">
                    <div class=""card flex-fill w-100"">
                        <div class=""card-header"">

                            <h5 class=""card-title mb-0"">Последние добавленные избранные товары</h5>
                        </div>
                        <div class=""card-body py-3"">
                            <table class=""table table-hover my-0"">
                                <thead>
                                <tr>
                                    <th class=""d-none d-xl-table-cell"">#</th>
                                    <th>Пользователь</th>
                                    <th class=""d-");
            WriteLiteral("none d-xl-table-cell\">Товар</th>\r\n                                    <th class=\"d-none d-xl-table-cell\">Цена</th>\r\n                                </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 80 "M:\KataStore\KS.WEB\Areas\Admin\Views\Home\Index.cshtml"
                                 foreach (var wishItem in Model.WishListVms)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ee20e1e0e79d6517f618e033da632eb2023920db11446", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4644, "~/", 4644, 2, true);
#nullable restore
#line 84 "M:\KataStore\KS.WEB\Areas\Admin\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4646, wishItem.ImageUrl, 4646, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 86 "M:\KataStore\KS.WEB\Areas\Admin\Views\Home\Index.cshtml"
                                       Write(wishItem.CustomerEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee20e1e0e79d6517f618e033da632eb2023920db13668", async() => {
#nullable restore
#line 88 "M:\KataStore\KS.WEB\Areas\Admin\Views\Home\Index.cshtml"
                                                                                                                                        Write(wishItem.ProductName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "M:\KataStore\KS.WEB\Areas\Admin\Views\Home\Index.cshtml"
                                                                                                            WriteLiteral(wishItem.ProductId);

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
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>₽ ");
#nullable restore
#line 90 "M:\KataStore\KS.WEB\Areas\Admin\Views\Home\Index.cshtml"
                                         Write(wishItem.Price.ToString("0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 92 "M:\KataStore\KS.WEB\Areas\Admin\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""row"">
                <div class=""col-12 col-md-6 col-xxl-3 d-flex order-2 order-xxl-3"">
                    <div class=""card flex-fill w-100"">
");
            WriteLiteral(@"                        <div class=""card-header"">
                            <h5 class=""card-title mb-0"">Календарь</h5>
                        </div>
                        <div class=""card-body d-flex"">
                            <div class=""align-self-center w-100"">
                                <div class=""chart"">
                                    <div id=""datetimepicker-dashboard""></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-12 col-lg-8 col-xxl-9 d-flex"">
                    <div class=""card flex-fill"">
                        <div class=""card-header"">

                            <h5 class=""card-title mb-0"">Последние заказы</h5>
                        </div>
                        <table class=""table table-hover my-0"">
                            <thead>
                            <tr>
                                <th class");
            WriteLiteral(@"=""d-none d-xl-table-cell"">Номер заказа</th>
                                <th>Пользователь</th>
                                <th class=""d-none d-xl-table-cell"">Дата</th>
                                <th class=""d-none d-xl-table-cell"">Цена</th>
                            </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 132 "M:\KataStore\KS.WEB\Areas\Admin\Views\Home\Index.cshtml"
                             foreach (var order in Model.LastOrdersVms)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "M:\KataStore\KS.WEB\Areas\Admin\Views\Home\Index.cshtml"
                           Write(await Html.PartialAsync("_LastOrdersPartial", order));

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "M:\KataStore\KS.WEB\Areas\Admin\Views\Home\Index.cshtml"
                                                                                     
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>


                </div>
            </div>
        </div>
    </div>
</div>

<script>
		document.addEventListener(""DOMContentLoaded"", function() {
			document.getElementById(""datetimepicker-dashboard"").flatpickr({
				inline: true,
				prevArrow: ""<span title=\""Previous month\"">&laquo;</span>"",
				nextArrow: ""<span title=\""Next month\"">&raquo;</span>"",
			});
		});
	</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> _signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KS.ViewModels.Order.OrderHomeVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
