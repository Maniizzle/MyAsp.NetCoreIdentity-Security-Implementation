#pragma checksum "C:\Users\OLAMIDE ONAKOYA\source\repos\MyAspIdentity\MyAspIdentity\Views\Claims\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "393cc9587414746414dace078b7434b488def46b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Claims_Index), @"mvc.1.0.view", @"/Views/Claims/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Claims/Index.cshtml", typeof(AspNetCore.Views_Claims_Index))]
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
#line 1 "C:\Users\OLAMIDE ONAKOYA\source\repos\MyAspIdentity\MyAspIdentity\Views\_ViewImports.cshtml"
using MyAspIdentity.Models;

#line default
#line hidden
#line 2 "C:\Users\OLAMIDE ONAKOYA\source\repos\MyAspIdentity\MyAspIdentity\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"393cc9587414746414dace078b7434b488def46b", @"/Views/Claims/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00b23cf2671c720b4babcb892c9cced870f7feb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Claims_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<System.Security.Claims.Claim>>
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
        private global::MyAspIdentity.CustomTagHelpers.ClaimTypeTagHelper __MyAspIdentity_CustomTagHelpers_ClaimTypeTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 232, true);
            WriteLiteral("<div class=\"bg-primary m-1 p-1 text-white\"><h4>Claims</h4></div>\r\n<table class=\"table table-sm table-bordered\">\r\n    <tr>\r\n        <th>Subject</th>\r\n        <th>Issuer</th>\r\n        <th>Type</th>\r\n        <th>Value</th>\r\n    </tr>\r\n");
            EndContext();
#line 10 "C:\Users\OLAMIDE ONAKOYA\source\repos\MyAspIdentity\MyAspIdentity\Views\Claims\Index.cshtml"
     if (Model == null || Model.Count() == 0)
    {

#line default
#line hidden
            BeginContext(336, 69, true);
            WriteLiteral("        <tr><td colspan=\"4\" class=\"text-center\">No Claims</td></tr>\r\n");
            EndContext();
#line 13 "C:\Users\OLAMIDE ONAKOYA\source\repos\MyAspIdentity\MyAspIdentity\Views\Claims\Index.cshtml"
    }
    else
    {
        

#line default
#line hidden
#line 16 "C:\Users\OLAMIDE ONAKOYA\source\repos\MyAspIdentity\MyAspIdentity\Views\Claims\Index.cshtml"
         foreach (var claim in Model.OrderBy(x => x.Type))
        {

#line default
#line hidden
            BeginContext(500, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(539, 18, false);
#line 19 "C:\Users\OLAMIDE ONAKOYA\source\repos\MyAspIdentity\MyAspIdentity\Views\Claims\Index.cshtml"
               Write(claim.Subject.Name);

#line default
#line hidden
            EndContext();
            BeginContext(557, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(585, 12, false);
#line 20 "C:\Users\OLAMIDE ONAKOYA\source\repos\MyAspIdentity\MyAspIdentity\Views\Claims\Index.cshtml"
               Write(claim.Issuer);

#line default
#line hidden
            EndContext();
            BeginContext(597, 23, true);
            WriteLiteral("</td>\r\n                ");
            EndContext();
            BeginContext(620, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("td", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "393cc9587414746414dace078b7434b488def46b5142", async() => {
            }
            );
            __MyAspIdentity_CustomTagHelpers_ClaimTypeTagHelper = CreateTagHelper<global::MyAspIdentity.CustomTagHelpers.ClaimTypeTagHelper>();
            __tagHelperExecutionContext.Add(__MyAspIdentity_CustomTagHelpers_ClaimTypeTagHelper);
            BeginWriteTagHelperAttribute();
#line 21 "C:\Users\OLAMIDE ONAKOYA\source\repos\MyAspIdentity\MyAspIdentity\Views\Claims\Index.cshtml"
                             WriteLiteral(claim.Type);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __MyAspIdentity_CustomTagHelpers_ClaimTypeTagHelper.ClaimType = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("identity-claim-type", __MyAspIdentity_CustomTagHelpers_ClaimTypeTagHelper.ClaimType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(663, 22, true);
            WriteLiteral("\r\n                <td>");
            EndContext();
            BeginContext(686, 11, false);
#line 22 "C:\Users\OLAMIDE ONAKOYA\source\repos\MyAspIdentity\MyAspIdentity\Views\Claims\Index.cshtml"
               Write(claim.Value);

#line default
#line hidden
            EndContext();
            BeginContext(697, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 24 "C:\Users\OLAMIDE ONAKOYA\source\repos\MyAspIdentity\MyAspIdentity\Views\Claims\Index.cshtml"
        }

#line default
#line hidden
#line 24 "C:\Users\OLAMIDE ONAKOYA\source\repos\MyAspIdentity\MyAspIdentity\Views\Claims\Index.cshtml"
         
    }

#line default
#line hidden
            BeginContext(741, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<System.Security.Claims.Claim>> Html { get; private set; }
    }
}
#pragma warning restore 1591
