#pragma checksum "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Views\Module\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9859a2dab7005ee4a6480b69512ebdf0501b2b46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Module_Detail), @"mvc.1.0.view", @"/Views/Module/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9859a2dab7005ee4a6480b69512ebdf0501b2b46", @"/Views/Module/Detail.cshtml")]
    public class Views_Module_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp1.Models.Module>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h2 class=\"card-title\">");
#nullable restore
#line 4 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Views\Module\Detail.cshtml"
                          Write(Model.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 4 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Views\Module\Detail.cshtml"
                                        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <table>\r\n            <thead>\r\n                <tr>\r\n                    <th>ProfessorId</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 14 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Views\Module\Detail.cshtml"
                 foreach (WebApp1.Models.ModuleProfessor item in ViewBag.moduleProfessors)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 17 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Views\Module\Detail.cshtml"
                       Write(item.ProfessorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 19 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Views\Module\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <form action=\"/\" method=\"post\">\r\n            <div >\r\n                <label>Professor</label>\r\n                <select name=\"professorId\" multiple>\r\n");
#nullable restore
#line 26 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Views\Module\Detail.cshtml"
                     foreach (WebApp1.Models.Professor item in ViewBag.professors)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 923, "\"", 939, 1);
#nullable restore
#line 28 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Views\Module\Detail.cshtml"
WriteAttributeValue("", 931, item.Id, 931, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Views\Module\Detail.cshtml"
                                            Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 29 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Views\Module\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n            </div>\r\n            <div>\r\n                <button>Save Changes</button>\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp1.Models.Module> Html { get; private set; }
    }
}
#pragma warning restore 1591