#pragma checksum "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "335895cfd3d4c0da7704b03460f3eca6f394aea8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consent_Index), @"mvc.1.0.view", @"/Views/Consent/Index.cshtml")]
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
#line 1 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"335895cfd3d4c0da7704b03460f3eca6f394aea8", @"/Views/Consent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f422aaa09212e40150922039b3abf2a62dc6b201", @"/Views/_ViewImports.cshtml")]
    public class Views_Consent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SsoProject.STS.Identity.ViewModels.Consent.ConsentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::SsoProject.STS.Identity.Helpers.TagHelpers.SwitchTagHelper __SsoProject_STS_Identity_Helpers_TagHelpers_SwitchTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"consent-container\">\r\n\t<div class=\"row page-header\">\r\n\t\t<div class=\"col-sm-10\">\r\n");
#nullable restore
#line 8 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
             if (Model.ClientLogoUrl != null)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"client-logo\"><img");
            BeginWriteAttribute("src", " src=\"", 319, "\"", 345, 1);
#nullable restore
#line 10 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
WriteAttributeValue("", 325, Model.ClientLogoUrl, 325, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 11 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<h1>\r\n\t\t\t\t");
#nullable restore
#line 13 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
           Write(Model.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t<small>");
#nullable restore
#line 14 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
                  Write(Localizer["SubTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n\t\t\t</h1>\r\n\t\t</div>\r\n\t</div>\r\n\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-sm-12\">\r\n\t\t\t");
#nullable restore
#line 21 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
       Write(await Html.PartialAsync("_ValidationSummary"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "335895cfd3d4c0da7704b03460f3eca6f394aea86357", async() => {
                WriteLiteral("\r\n\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "335895cfd3d4c0da7704b03460f3eca6f394aea86623", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 24 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ReturnUrl);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\t\t\t\t<div>");
#nullable restore
#line 26 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
                Write(Localizer["UnCheckPermission"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 28 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
                 if (Model.IdentityScopes.Any())
				{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t<div class=\"col-sm-12\">\r\n\t\t\t\t\t\t<div class=\"card mt-3\">\r\n\t\t\t\t\t\t\t<h5 class=\"card-header\">\r\n\t\t\t\t\t\t\t\t<i class=\"fa fa-user\"></i>\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 34 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
                           Write(Localizer["PersonalInformation"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t</h5>\r\n\t\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t\t<ul class=\"list-group\">\r\n");
#nullable restore
#line 38 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
                                     foreach (var scope in Model.IdentityScopes)
									{
										

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
                                   Write(await Html.PartialAsync("_ScopeListItem", scope));

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
                                                                                         
									}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 46 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
                 if (Model.ApiScopes.Any())
				{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t<div class=\"col-sm-12\">\r\n\t\t\t\t\t\t<div class=\"card mt-3\">\r\n\t\t\t\t\t\t\t<h5 class=\"card-header\">\r\n\t\t\t\t\t\t\t\t<i class=\"fa fa-lock\"></i> ");
#nullable restore
#line 53 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
                                                      Write(Localizer["ApplicationAccess"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t</h5>\r\n\t\t\t\t\t\t\t<div class=\"card-body\">\r\n\r\n\t\t\t\t\t\t\t\t<ul class=\"list-group\">\r\n");
#nullable restore
#line 58 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
                                     foreach (var scope in Model.ApiScopes)
									{
										

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
                                   Write(await Html.PartialAsync("_ScopeListItem", scope));

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
                                                                                         
									}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 66 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 68 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
                 if (Model.AllowRememberConsent)
				{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t<div class=\"row m-4\">\r\n\t\t\t\t\t\t<div class=\"col-sm-12\">\r\n\t\t\t\t\t\t\t<div class=\"toggle-button__input\">\r\n\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("toggle-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "335895cfd3d4c0da7704b03460f3eca6f394aea813174", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "335895cfd3d4c0da7704b03460f3eca6f394aea813468", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 74 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RememberConsent);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
                }
                );
                __SsoProject_STS_Identity_Helpers_TagHelpers_SwitchTagHelper = CreateTagHelper<global::SsoProject.STS.Identity.Helpers.TagHelpers.SwitchTagHelper>();
                __tagHelperExecutionContext.Add(__SsoProject_STS_Identity_Helpers_TagHelpers_SwitchTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"toggle-button__text\">\r\n\t\t\t\t\t\t\t\t<strong>");
#nullable restore
#line 78 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
                                   Write(Localizer["Remember"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 82 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t<div class=\"row ml-4 mr-4\">\r\n\t\t\t\t\t<div class=\"col-sm-9 mt-3\">\r\n\t\t\t\t\t\t<button name=\"button\" value=\"yes\" class=\"btn btn-primary\" autofocus>");
#nullable restore
#line 86 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
                                                                                       Write(Localizer["Yes"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n\t\t\t\t\t\t<button name=\"button\" value=\"no\" class=\"btn\">");
#nullable restore
#line 87 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
                                                                Write(Localizer["No"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t<div class=\"col-sm-3 mt-3\">\r\n");
#nullable restore
#line 91 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
                         if (Model.ClientUrl != null)
						{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t<a class=\"btn btn-outline-primary\" target=\"_blank\"");
                BeginWriteAttribute("href", " href=\"", 2506, "\"", 2529, 1);
#nullable restore
#line 93 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
WriteAttributeValue("", 2513, Model.ClientUrl, 2513, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<i class=\"fa fa-info-circle\"></i>\r\n\t\t\t\t\t\t\t\t<strong>");
#nullable restore
#line 95 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
                                   Write(Model.ClientName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n\t\t\t\t\t\t\t</a>\r\n");
#nullable restore
#line 97 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Consent\Index.cshtml"
						}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUrlHelper UrlHelper { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SsoProject.STS.Identity.ViewModels.Consent.ConsentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
