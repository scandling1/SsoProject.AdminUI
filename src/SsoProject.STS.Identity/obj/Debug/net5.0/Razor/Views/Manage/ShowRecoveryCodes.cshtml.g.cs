#pragma checksum "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Manage\ShowRecoveryCodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e615dc5cdb722cdb963cbb93a46eddad03120555"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_ShowRecoveryCodes), @"mvc.1.0.view", @"/Views/Manage/ShowRecoveryCodes.cshtml")]
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
#line 2 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Manage\ShowRecoveryCodes.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e615dc5cdb722cdb963cbb93a46eddad03120555", @"/Views/Manage/ShowRecoveryCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f422aaa09212e40150922039b3abf2a62dc6b201", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_ShowRecoveryCodes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SsoProject.STS.Identity.ViewModels.Manage.ShowRecoveryCodesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Manage\ShowRecoveryCodes.cshtml"
  
    ViewData["Title"] = Localizer["Title"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>");
#nullable restore
#line 8 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Manage\ShowRecoveryCodes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<div class=\"alert alert-warning\" role=\"alert\">\r\n    <p>\r\n        <span class=\"fa fa-exclamation-triangle\"></span>\r\n        <strong>");
#nullable restore
#line 12 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Manage\ShowRecoveryCodes.cshtml"
           Write(Localizer["SubTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n    </p>\r\n    <p>\r\n        ");
#nullable restore
#line 15 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Manage\ShowRecoveryCodes.cshtml"
   Write(Localizer["Info"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 20 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Manage\ShowRecoveryCodes.cshtml"
         for (var row = 0; row < Model.RecoveryCodes.Length; row += 2)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <code>");
#nullable restore
#line 22 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Manage\ShowRecoveryCodes.cshtml"
             Write(Model.RecoveryCodes[row]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>");
            WriteLiteral("&nbsp;");
            WriteLiteral("<code>");
#nullable restore
#line 22 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Manage\ShowRecoveryCodes.cshtml"
                                                                      Write(Model.RecoveryCodes[row + 1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code><br />\r\n");
#nullable restore
#line 23 "C:\Users\Scandling\RiderProjects\SsoProject\src\SsoProject.STS.Identity\Views\Manage\ShowRecoveryCodes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SsoProject.STS.Identity.ViewModels.Manage.ShowRecoveryCodesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
