#pragma checksum "E:\Czar.Cms-master\src\Czar.Cms.Admin\Views\TaskInfo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bf55e2f710d83e3bfc09494bff96a6da70e1be8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TaskInfo_Index), @"mvc.1.0.view", @"/Views/TaskInfo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TaskInfo/Index.cshtml", typeof(AspNetCore.Views_TaskInfo_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bf55e2f710d83e3bfc09494bff96a6da70e1be8", @"/Views/TaskInfo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"531546f7706fc96f063efa9c00dbc5251e0428dd", @"/Views/_ViewImports.cshtml")]
    public class Views_TaskInfo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\Czar.Cms-master\src\Czar.Cms.Admin\Views\TaskInfo\Index.cshtml"
  
    ViewData["Title"] = "定时任务管理";

#line default
#line hidden
            BeginContext(42, 52, true);
            WriteLiteral("<blockquote class=\"layui-elem-quote quoteBox\">\r\n    ");
            EndContext();
            BeginContext(94, 881, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bf55e2f710d83e3bfc09494bff96a6da70e1be84721", async() => {
                BeginContext(119, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(130, 23, false);
#line 6 "E:\Czar.Cms-master\src\Czar.Cms.Admin\Views\TaskInfo\Index.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(153, 815, true);
                WriteLiteral(@"
        <div class=""layui-inline"">
            <div class=""layui-input-inline"">
                <input type=""text"" class=""layui-input searchVal"" placeholder=""请输入任务名称"" />
            </div>
            <a class=""layui-btn search_btn"" data-type=""reload"">搜索</a>
        </div>
        <div class=""layui-inline"">
            <a class=""layui-btn layui-btn-normal addTask_btn""><i class=""layui-icon"">&#xe61f;</i>添加任务</a>
        </div>
        <div class=""layui-inline"">
            <a class=""layui-btn layui-btn-normal layui-btn-normal stopAll_btn""><i class=""layui-icon layui-icon-normal""></i>批量停止</a>
        </div>
        <div class=""layui-inline"">
            <a class=""layui-btn layui-btn-normal layui-btn-normal startAll_btn""><i class=""layui-icon layui-icon-normal""></i>批量启动</a>
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
            BeginContext(975, 624, true);
            WriteLiteral(@"
</blockquote>
<table id=""taskList"" lay-filter=""taskList""></table>
<!--操作-->
<script type=""text/html"" id=""taskBar"">
    <a class=""layui-btn layui-btn-xs"" lay-event=""edit"">编辑</a>
    <a class=""layui-btn layui-btn-xs layui-btn-danger"" lay-event=""del"">删除</a>
</script>
<script type=""text/html"" id=""IsRun"">
    {{#  if(d.Status ===0){ }}
    <input type=""checkbox"" name=""IsRun"" value=""{{d.Id}}"" lay-filter=""IsRun"" lay-skin=""switch"" lay-text=""启动|停止"" checked>
    {{#  } else{ }}
    <input type=""checkbox"" name=""IsRun"" value=""{{d.Id}}"" lay-filter=""IsRun"" lay-skin=""switch"" lay-text=""启动|停止"">
    {{#  }}}
</script>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1616, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1622, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bf55e2f710d83e3bfc09494bff96a6da70e1be88288", async() => {
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
                BeginContext(1685, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1691, 111, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bf55e2f710d83e3bfc09494bff96a6da70e1be89631", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1727, "~/js/task/taskList.js?_=", 1727, 24, true);
#line 39 "E:\Czar.Cms-master\src\Czar.Cms.Admin\Views\TaskInfo\Index.cshtml"
AddHtmlAttributeValue("", 1751, DateTime.Now.ToString("yyyyMMddHHmmss"), 1751, 40, false);

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
                BeginContext(1802, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(1807, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
