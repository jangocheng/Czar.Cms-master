#pragma checksum "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\ManagerInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b12303d8cbc88169110963b35e7503ff9f5e32c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_ManagerInfo), @"mvc.1.0.view", @"/Views/Manager/ManagerInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manager/ManagerInfo.cshtml", typeof(AspNetCore.Views_Manager_ManagerInfo))]
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
#line 1 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\_ViewImports.cshtml"
using Czar.Cms.Admin;

#line default
#line hidden
#line 2 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\_ViewImports.cshtml"
using Czar.Cms.Admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b12303d8cbc88169110963b35e7503ff9f5e32c", @"/Views/Manager/ManagerInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12ac5d09335c7f224d6c7cc7745c338d8f15159c", @"/Views/_ViewImports.cshtml")]
    public class Views_Manager_ManagerInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Czar.Cms.Models.Manager>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form layui-row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\ManagerInfo.cshtml"
  
    ViewData["Title"] = "个人信息";

#line default
#line hidden
            BeginContext(68, 2827, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b12303d8cbc88169110963b35e7503ff9f5e32c4629", async() => {
                BeginContext(103, 115, true);
                WriteLiteral("\n    <div class=\"layui-col-md3 layui-col-xs12 user_right\">\n        <div class=\"layui-upload-list\">\n            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 218, "\"", 237, 1);
#line 8 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\ManagerInfo.cshtml"
WriteAttributeValue("", 224, Model.Avatar, 224, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(238, 236, true);
                WriteLiteral(" class=\"layui-upload-img layui-circle userFaceBtn userAvatar\" id=\"userFace\">\n        </div>\n        <button type=\"button\" class=\"layui-btn layui-btn-primary userFaceBtn\"><i class=\"layui-icon\">&#xe67c;</i> 掐指一算，我要换一个头像了</button>\n        ");
                EndContext();
                BeginContext(475, 35, false);
#line 11 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\ManagerInfo.cshtml"
   Write(Html.Hidden("Avatar", Model.Avatar));

#line default
#line hidden
                EndContext();
                BeginContext(510, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(520, 27, false);
#line 12 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\ManagerInfo.cshtml"
   Write(Html.Hidden("Id", Model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(547, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(557, 23, false);
#line 13 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\ManagerInfo.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(580, 240, true);
                WriteLiteral("\n    </div>\n    <div class=\"layui-col-md6 layui-col-xs12\">\n        <div class=\"layui-form-item\" pane=\"\">\n            <label class=\"layui-form-label\">用户账号</label>\n            <div class=\"layui-input-block\">\n                <input type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 820, "\"", 843, 1);
#line 19 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\ManagerInfo.cshtml"
WriteAttributeValue("", 828, Model.UserName, 828, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(844, 292, true);
                WriteLiteral(@" name=""UserName"" ,id=""UserName"" disabled class=""layui-input layui-disabled"">
            </div>
        </div>
        <div class=""layui-form-item"" pane="""">
            <label class=""layui-form-label"">用户角色</label>
            <div class=""layui-input-block"">
                <input type=""text""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1136, "\"", 1159, 1);
#line 25 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\ManagerInfo.cshtml"
WriteAttributeValue("", 1144, Model.RoleName, 1144, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1160, 291, true);
                WriteLiteral(@" name=""RoleName"" id=""RoleName"" disabled class=""layui-input layui-disabled"">
            </div>
        </div>
        <div class=""layui-form-item"" pane="""">
            <label class=""layui-form-label"">真实姓名</label>
            <div class=""layui-input-block"">
                <input type=""text""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1451, "\"", 1474, 1);
#line 31 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\ManagerInfo.cshtml"
WriteAttributeValue("", 1459, Model.NickName, 1459, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1475, 319, true);
                WriteLiteral(@" name=""NickName"" id=""NickName"" placeholder=""请输入真实姓名"" lay-verify=""required"" class=""layui-input realName"">
            </div>
        </div>
        <div class=""layui-form-item"" pane="""">
            <label class=""layui-form-label"">手机号码</label>
            <div class=""layui-input-block"">
                <input type=""tel""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1794, "\"", 1815, 1);
#line 37 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\ManagerInfo.cshtml"
WriteAttributeValue("", 1802, Model.Mobile, 1802, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1816, 313, true);
                WriteLiteral(@" name=""Mobile"" id=""Mobile"" placeholder=""请输入手机号码"" lay-verify=""phone"" class=""layui-input userPhone"">
            </div>
        </div>
        <div class=""layui-form-item"" pane="""">
            <label class=""layui-form-label"">电子邮箱</label>
            <div class=""layui-input-block"">
                <input type=""tel""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2129, "\"", 2149, 1);
#line 43 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\ManagerInfo.cshtml"
WriteAttributeValue("", 2137, Model.Email, 2137, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2150, 370, true);
                WriteLiteral(@" name=""Email"" id=""Email"" placeholder=""请输入电子邮箱"" lay-verify=""email"" class=""layui-input userPhone"">
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">备注</label>
            <div class=""layui-input-block"">
                <textarea placeholder=""请输入内容"" name=""Remark"" id=""Remark"" class=""layui-textarea myself"">");
                EndContext();
                BeginContext(2521, 12, false);
#line 49 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\ManagerInfo.cshtml"
                                                                                                 Write(Model.Remark);

#line default
#line hidden
                EndContext();
                BeginContext(2533, 355, true);
                WriteLiteral(@"</textarea>
            </div>
        </div>
        <div class=""layui-form-item"">
            <div class=""layui-input-block"">
                <button class=""layui-btn"" lay-submit="""" lay-filter=""changeManager"">立即提交</button>
                <button type=""reset"" class=""layui-btn layui-btn-primary"">重置</button>
            </div>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2895, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2913, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(2918, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b12303d8cbc88169110963b35e7503ff9f5e32c12948", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2981, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(2986, 117, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b12303d8cbc88169110963b35e7503ff9f5e32c14290", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3022, "~/js/manager/managerInfo.js?_=", 3022, 30, true);
#line 62 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\ManagerInfo.cshtml"
AddHtmlAttributeValue("", 3052, DateTime.Now.ToString("yyyyMMddHHmmss"), 3052, 40, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3103, 1, true);
                WriteLiteral("\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Czar.Cms.Models.Manager> Html { get; private set; }
    }
}
#pragma warning restore 1591
