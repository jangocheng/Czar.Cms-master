#pragma checksum "E:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\AddOrModify.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d42f9132cc48e3cf758eee6e4f36684f12c323fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_AddOrModify), @"mvc.1.0.view", @"/Views/Manager/AddOrModify.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manager/AddOrModify.cshtml", typeof(AspNetCore.Views_Manager_AddOrModify))]
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
#line 1 "E:\Czar.Cms-master\src\Czar.Cms.Admin\Views\_ViewImports.cshtml"
using Czar.Cms.Admin;

#line default
#line hidden
#line 2 "E:\Czar.Cms-master\src\Czar.Cms.Admin\Views\_ViewImports.cshtml"
using Czar.Cms.Admin.Models;

#line default
#line hidden
#line 1 "E:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\AddOrModify.cshtml"
using Czar.Cms.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d42f9132cc48e3cf758eee6e4f36684f12c323fa", @"/Views/Manager/AddOrModify.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"531546f7706fc96f063efa9c00dbc5251e0428dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Manager_AddOrModify : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ManagerRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form layui-form-pane"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:90%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\AddOrModify.cshtml"
  
    ViewData["Title"] = "用户管理";

#line default
#line hidden
            BeginContext(90, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(92, 2800, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d42f9132cc48e3cf758eee6e4f36684f12c323fa5352", async() => {
                BeginContext(152, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(159, 23, false);
#line 8 "E:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\AddOrModify.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(182, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(189, 17, false);
#line 9 "E:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\AddOrModify.cshtml"
Write(Html.Hidden("Id"));

#line default
#line hidden
                EndContext();
                BeginContext(206, 564, true);
                WriteLiteral(@"
    <div class=""layui-form-item layui-row layui-col-xs12"">
        <label class=""layui-form-label"">登陆ID</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""UserName"" class=""layui-input UserName"" lay-verify=""required|username"" placeholder=""请输入登录ID"">
        </div>
    </div>
    <div class=""layui-form-item layui-row layui-col-xs12"">
        <label class=""layui-form-label"">所属角色</label>
        <div class=""layui-input-block"">
            <select name=""RoleId"" class=""RoleId"" lay-filter=""RoleId"" lay-verify=""required"">
");
                EndContext();
#line 20 "E:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\AddOrModify.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
                BeginContext(835, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(855, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d42f9132cc48e3cf758eee6e4f36684f12c323fa7317", async() => {
                    BeginContext(881, 13, false);
#line 22 "E:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\AddOrModify.cshtml"
                                        Write(item.RoleName);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 22 "E:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\AddOrModify.cshtml"
                       WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(903, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 23 "E:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\AddOrModify.cshtml"
                }

#line default
#line hidden
                BeginContext(924, 1961, true);
                WriteLiteral(@"            </select>
        </div>
    </div>
    <div class=""layui-form-item layui-row layui-col-xs12"">
        <label class=""layui-form-label"">用户昵称</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""NickName"" class=""layui-input NickName"" placeholder=""请输入用户昵称"" lay-verify=""required|username"" autocomplete=""off"" />
        </div>
    </div>
    <div class=""layui-form-item layui-row layui-col-xs12"">
        <label class=""layui-form-label"">手机号码</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""Mobile"" class=""layui-input Mobile"" placeholder=""请输入手机号码"" lay-verify=""phone|number"" autocomplete=""off"" />
        </div>
    </div>
    <div class=""layui-form-item layui-row layui-col-xs12"">
        <label class=""layui-form-label"">邮箱地址</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""Email"" class=""layui-input Email"" placeholder=""请输入邮箱地址"" lay-verify=""email"" autocomplete=""off"" />
        </div>
    </d");
                WriteLiteral(@"iv>
    <div class=""layui-form-item layui-row layui-col-xs12"" pane>
        <label class=""layui-form-label"">是否锁定</label>
        <div class=""layui-input-block"">
            <input type=""checkbox"" name=""IsLock"" class=""IsLock"" lay-filter=""IsLock"" lay-skin=""switch"" lay-text=""是|否"" value=""1""/>
        </div>
    </div>
    <div class=""layui-form-item layui-form-text layui-col-xs12"">
        <label class=""layui-form-label"">备注</label>
        <div class=""layui-input-block"">
            <textarea placeholder=""请输入备注信息"" name=""Remark"" class=""layui-textarea Remark""></textarea>
        </div>
    </div>
    <div class=""layui-form-item layui-row layui-col-xs12"">
        <div class=""layui-input-block"">
            <button class=""layui-btn layui-btn-sm"" lay-submit="""" lay-filter=""addManager"">确定</button>
            <button type=""reset"" class=""layui-btn layui-btn-sm layui-btn-primary"">重置</button>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2892, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2911, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2917, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d42f9132cc48e3cf758eee6e4f36684f12c323fa13078", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2980, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2986, 116, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d42f9132cc48e3cf758eee6e4f36684f12c323fa14422", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3022, "~/js/manager/managerAdd.js?_=", 3022, 29, true);
#line 66 "E:\Czar.Cms-master\src\Czar.Cms.Admin\Views\Manager\AddOrModify.cshtml"
AddHtmlAttributeValue("", 3051, DateTime.Now.ToString("yyyyMMddHHmmss"), 3051, 40, false);

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
                BeginContext(3102, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(3107, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ManagerRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
