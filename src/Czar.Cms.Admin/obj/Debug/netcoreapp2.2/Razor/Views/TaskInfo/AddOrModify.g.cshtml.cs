#pragma checksum "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\TaskInfo\AddOrModify.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9310f2bb734513c9d1208d9ccad6dbed00ebce69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TaskInfo_AddOrModify), @"mvc.1.0.view", @"/Views/TaskInfo/AddOrModify.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TaskInfo/AddOrModify.cshtml", typeof(AspNetCore.Views_TaskInfo_AddOrModify))]
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
#line 1 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\TaskInfo\AddOrModify.cshtml"
using Czar.Cms.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9310f2bb734513c9d1208d9ccad6dbed00ebce69", @"/Views/TaskInfo/AddOrModify.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12ac5d09335c7f224d6c7cc7745c338d8f15159c", @"/Views/_ViewImports.cshtml")]
    public class Views_TaskInfo_AddOrModify : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Menu>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\TaskInfo\AddOrModify.cshtml"
  
    ViewData["Title"] = "定时任务";

#line default
#line hidden
            BeginContext(78, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(79, 2216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9310f2bb734513c9d1208d9ccad6dbed00ebce695218", async() => {
                BeginContext(139, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(145, 23, false);
#line 8 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\TaskInfo\AddOrModify.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(168, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(174, 17, false);
#line 9 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\TaskInfo\AddOrModify.cshtml"
Write(Html.Hidden("Id"));

#line default
#line hidden
                EndContext();
                BeginContext(191, 2097, true);
                WriteLiteral(@"
    <div class=""layui-form-item layui-row layui-col-xs12"">
        <label class=""layui-form-label"">调用别名</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""Name"" class=""layui-input Name"" lay-verify=""required|Name"" placeholder=""只允许字母数字下划线"">
        </div>
    </div>
    <div class=""layui-form-item layui-row layui-col-xs12"">
        <label class=""layui-form-label"">分组名称</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""Group"" class=""layui-input Group"" lay-verify=""required"" placeholder=""请输入显示名称"">
        </div>
    </div>
    <div class=""layui-form-item layui-row layui-col-xs12"">
        <label class=""layui-form-label"">程序集路径</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""Assembly"" class=""layui-input Assembly"" lay-verify=""required"" placeholder=""请输入显示名称"">
        </div>
    </div>
    <div class=""layui-form-item layui-row layui-col-xs12"">
        <label class=""layui-form-label"">完整类名</label>
        <div class=");
                WriteLiteral(@"""layui-input-block"">
            <input type=""text"" name=""ClassName"" class=""layui-input ClassName"" lay-verify=""required"" placeholder=""请输入显示名称"">
        </div>
    </div>
    <div class=""layui-form-item layui-row layui-col-xs12"">
        <label class=""layui-form-label"">Cron表达式</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""Cron"" class=""layui-input Cron"" lay-verify=""required"" placeholder=""请输入显示名称"">
        </div>
    </div>
    <div class=""layui-form-item layui-form-text layui-col-xs12"">
        <label class=""layui-form-label"">备注</label>
        <div class=""layui-input-block"">
            <textarea placeholder=""请输入描述信息"" name=""Description"" class=""layui-textarea Description""></textarea>
        </div>
    </div>
    <div class=""layui-form-item layui-row layui-col-xs12"">
        <div class=""layui-input-block"">
            <button class=""layui-btn layui-btn-sm"" lay-submit="""" lay-filter=""addTask"">确定</button>
            <button type=""reset"" class=""layui-btn layui-btn-sm layui-bt");
                WriteLiteral("n-primary\">重置</button>\n        </div>\n    </div>\n");
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
            BeginContext(2295, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2313, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(2318, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9310f2bb734513c9d1208d9ccad6dbed00ebce699961", async() => {
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
                BeginContext(2381, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(2386, 110, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9310f2bb734513c9d1208d9ccad6dbed00ebce6911302", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2422, "~/js/task/taskAdd.js?_=", 2422, 23, true);
#line 55 "D:\Czar.Cms-master\src\Czar.Cms.Admin\Views\TaskInfo\AddOrModify.cshtml"
AddHtmlAttributeValue("", 2445, DateTime.Now.ToString("yyyyMMddHHmmss"), 2445, 40, false);

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
                BeginContext(2496, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(2499, 3, true);
            WriteLiteral("\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Menu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
