#pragma checksum "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Registration\updateProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4393d9de7b347e051b6840ba8a3faa6797484315"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registration_updateProfile), @"mvc.1.0.view", @"/Views/Registration/updateProfile.cshtml")]
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
#line 1 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\_ViewImports.cshtml"
using OnlineBank;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\_ViewImports.cshtml"
using OnlineBank.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4393d9de7b347e051b6840ba8a3faa6797484315", @"/Views/Registration/updateProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7056404dc4d8e87fa87377e5f202d17ac0d756fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Registration_updateProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineBank.Models.Registration>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Registration\updateProfile.cshtml"
  
    ViewBag.Title = "Update Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 9 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Registration\updateProfile.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<hr />\r\n<div class=\"container\">\r\n    <div class=\"leftdiv\">\r\n");
#nullable restore
#line 13 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Registration\updateProfile.cshtml"
         using (Html.BeginForm("updateProfile", "Registration", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                ");
#nullable restore
#line 16 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Registration\updateProfile.cshtml"
           Write(Html.HiddenFor(m => m.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"row\">\r\n                ");
#nullable restore
#line 19 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Registration\updateProfile.cshtml"
           Write(Html.LabelFor(m => m.Name, new { @class = "lbl" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Registration\updateProfile.cshtml"
           Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Registration\updateProfile.cshtml"
           Write(Html.ValidationMessageFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"row\">\r\n                ");
#nullable restore
#line 25 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Registration\updateProfile.cshtml"
           Write(Html.LabelFor(m => m.Contact_No, new { @class = "lbl" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 26 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Registration\updateProfile.cshtml"
           Write(Html.TextBoxFor(m => m.Contact_No));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 27 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Registration\updateProfile.cshtml"
           Write(Html.ValidationMessageFor(m => m.Contact_No));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"row\">\r\n                ");
#nullable restore
#line 30 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Registration\updateProfile.cshtml"
           Write(Html.LabelFor(m => m.Email, new { @class = "lbl" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 31 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Registration\updateProfile.cshtml"
           Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 32 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Registration\updateProfile.cshtml"
           Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"row\">\r\n                ");
#nullable restore
#line 35 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Registration\updateProfile.cshtml"
           Write(Html.LabelFor(m => m.Password, new { @class = "lbl" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 36 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Registration\updateProfile.cshtml"
           Write(Html.TextBoxFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 37 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Registration\updateProfile.cshtml"
           Write(Html.ValidationMessageFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div style=\" margin-top: 2rem; margin-left: -0.8rem; float: left;\">\r\n                <button class=\"btn\" type=\"submit\">Update Profile</button>\r\n            </div>\r\n");
#nullable restore
#line 42 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Registration\updateProfile.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<style>

    .lbl {
        display: block;
        width: 100%;
    }

    .btn {
        background: black;
        color: white;
        border: none;
    }

    .field-validation-error {
        color: Red;
    }

    .leftdiv {
        width: 50%;
        float: left;
    }

    .rightdiv {
        width: 50%;
        float: right;
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineBank.Models.Registration> Html { get; private set; }
    }
}
#pragma warning restore 1591