#pragma checksum "C:\Users\Lenovo\Desktop\Adam\IGI_6\IGI_6\Views\Home\Worker.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f42b825212a537a5b309ac227cd5740450557a2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Worker), @"mvc.1.0.view", @"/Views/Home/Worker.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Worker.cshtml", typeof(AspNetCore.Views_Home_Worker))]
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
#line 1 "C:\Users\Lenovo\Desktop\Adam\IGI_6\IGI_6\Views\_ViewImports.cshtml"
using IGI_6;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\Desktop\Adam\IGI_6\IGI_6\Views\_ViewImports.cshtml"
using IGI_6.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f42b825212a537a5b309ac227cd5740450557a2b", @"/Views/Home/Worker.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14675d5b518b11293ea926fdd10875a2772f4a9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Worker : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Lenovo\Desktop\Adam\IGI_6\IGI_6\Views\Home\Worker.cshtml"
  
    ViewData["Title"] = "worker";

#line default
#line hidden
            BeginContext(42, 188, true);
            WriteLiteral("\r\n<h2>worker</h2>\r\n\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <td>Name</td>\r\n    </tr>\r\n    <tbody id=\"vals\"></tbody>\r\n</table>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            EndContext();
            BeginContext(230, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ff9d6ddcfe94a919d8b84ba18db11e3", async() => {
                BeginContext(249, 95, true);
                WriteLiteral("\r\n            <div>Name</div>\r\n            <input name=\"Name\" class=\"form-control\" />\r\n        ");
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
            BeginContext(351, 107, true);
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Create\" class=\"sendForm btn btn-default\" />\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(481, 94, true);
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(_ => {\r\n            $.ajax({\r\n                url: \'");
                EndContext();
                BeginContext(576, 27, false);
#line 31 "C:\Users\Lenovo\Desktop\Adam\IGI_6\IGI_6\Views\Home\Worker.cshtml"
                 Write(Url.Action("worker", "api"));

#line default
#line hidden
                EndContext();
                BeginContext(603, 204, true);
                WriteLiteral("\',\r\n                type: \"GET\",\r\n                success: res => loadTable(res)\r\n            })\r\n        });\r\n       $(document).on(\"click\", \".del\", e => {\r\n\r\n            $.ajax({\r\n                url: \'");
                EndContext();
                BeginContext(808, 27, false);
#line 39 "C:\Users\Lenovo\Desktop\Adam\IGI_6\IGI_6\Views\Home\Worker.cshtml"
                 Write(Url.Action("worker", "api"));

#line default
#line hidden
                EndContext();
                BeginContext(835, 724, true);
                WriteLiteral(@"?id=' + e.target.id,
                type: ""DELETE"",
                success: res => loadTable(res)
            });
        });

        $(document).on(""click"", "".sendForm"", e => {
            var worker = $(""#addForm"").serializeArray().reduce((prev, cur) => {
                if (prev != undefined)
                    prev[cur.name] = cur.value;
                else prev = { [cur.name]: cur.value };

                return prev;

            }, undefined);
            for (let val in worker) {
                if (worker[val] == """" || worker[val] == null) {
                    alert(""Error"");
                    return;
                }
            }
            $.ajax({
                url: '");
                EndContext();
                BeginContext(1560, 29, false);
#line 61 "C:\Users\Lenovo\Desktop\Adam\IGI_6\IGI_6\Views\Home\Worker.cshtml"
                 Write(Url.Action("addWorker","api"));

#line default
#line hidden
                EndContext();
                BeginContext(1589, 683, true);
                WriteLiteral(@"',
                type: ""POST"",
                data: {
                    worker: worker
                },
                success: res => {
                    loadTable(res)
                }
            })

        });

        function loadTable(res) {

            $(""tbody#vals"").html("""");
            for (let i = 0; i < res.length; i++) {
                $(""tbody#vals"").append(`
                            <tr>
                                <td>${res[i].name}</td>
                                <td class=""del"" id=""${res[i].id}"">x</td>
                            </tr>
                            `);
            }
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591