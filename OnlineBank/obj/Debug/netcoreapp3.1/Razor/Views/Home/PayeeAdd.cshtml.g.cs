#pragma checksum "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Home\PayeeAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a068f2051905553c57e51146310b0a9075321ec9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PayeeAdd), @"mvc.1.0.view", @"/Views/Home/PayeeAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a068f2051905553c57e51146310b0a9075321ec9", @"/Views/Home/PayeeAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7056404dc4d8e87fa87377e5f202d17ac0d756fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PayeeAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineBank.Models.Benficiarys>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Home\PayeeAdd.cshtml"
  
    ViewBag.Title = "Benficiary Add";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Add Payee </h1>\r\n<hr />\r\n<div class=\"container\">\r\n    <div class=\"leftdiv\">\r\n");
#nullable restore
#line 13 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Home\PayeeAdd.cshtml"
         using (Html.BeginForm("PayeeAdd", "Home", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                ");
#nullable restore
#line 16 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Home\PayeeAdd.cshtml"
           Write(Html.LabelFor(m => m.Payee_Name, new { @class = "lbl" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 17 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Home\PayeeAdd.cshtml"
           Write(Html.TextBoxFor(m => m.Payee_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 18 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Home\PayeeAdd.cshtml"
           Write(Html.ValidationMessageFor(m => m.Payee_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"row\">\r\n                ");
#nullable restore
#line 21 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Home\PayeeAdd.cshtml"
           Write(Html.LabelFor(m => m.Payee_Contact, new { @class = "lbl" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 22 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Home\PayeeAdd.cshtml"
           Write(Html.TextBoxFor(m => m.Payee_Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 23 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Home\PayeeAdd.cshtml"
           Write(Html.ValidationMessageFor(m => m.Payee_Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"row\">\r\n                ");
#nullable restore
#line 26 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Home\PayeeAdd.cshtml"
           Write(Html.LabelFor(m => m.Bnak_name, new { @class = "lbl" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 27 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Home\PayeeAdd.cshtml"
           Write(Html.TextBoxFor(m => m.Bnak_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 28 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Home\PayeeAdd.cshtml"
           Write(Html.ValidationMessageFor(m => m.Bnak_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"row\">\r\n                ");
#nullable restore
#line 31 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Home\PayeeAdd.cshtml"
           Write(Html.LabelFor(m => m.Customer, new { @class = "lbl" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 32 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Home\PayeeAdd.cshtml"
           Write(Html.TextBoxFor(m => m.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 33 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Home\PayeeAdd.cshtml"
           Write(Html.ValidationMessageFor(m => m.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral(@"            <div style="" margin-top: 2rem; margin-left: -0.8rem; float: left;"">
                <button class=""btn"" type=""submit"">Add</button>
            </div>
            <div style="" margin-top: 2rem; margin-left: 33px; float: left;"">
                <button class=""btn""");
            BeginWriteAttribute("onclick", " onclick=\"", 1503, "\"", 1564, 4);
            WriteAttributeValue("", 1513, "location.href=\'", 1513, 15, true);
#nullable restore
#line 40 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Home\PayeeAdd.cshtml"
WriteAttributeValue("", 1528, Url.Action("Payees"), 1528, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1549, "\';return", 1549, 8, true);
            WriteAttributeValue(" ", 1557, "false;", 1558, 7, true);
            EndWriteAttribute();
            WriteLiteral(">Cancel</button>\r\n            </div>\r\n");
#nullable restore
#line 42 "C:\Users\GangadharCh\source\repos\OnlineBank\OnlineBank\Views\Home\PayeeAdd.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineBank.Models.Benficiarys> Html { get; private set; }
    }
}
#pragma warning restore 1591