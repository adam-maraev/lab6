#pragma checksum "C:\Users\Lenovo\Desktop\Adam\IGI_6\IGI_6\Views\Home\Furniture.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf811984ac3b2cd549bed809647375af3f731426"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Furniture), @"mvc.1.0.view", @"/Views/Home/Furniture.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Furniture.cshtml", typeof(AspNetCore.Views_Home_Furniture))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf811984ac3b2cd549bed809647375af3f731426", @"/Views/Home/Furniture.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14675d5b518b11293ea926fdd10875a2772f4a9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Furniture : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\Lenovo\Desktop\Adam\IGI_6\IGI_6\Views\Home\Furniture.cshtml"
  
    ViewData["Title"] = "furniture";

#line default
#line hidden
            BeginContext(45, 295, true);
            WriteLiteral(@"
<h2>furniture</h2>


<table class=""table"">
    <tr>
        <td>Name</td>
        <td>Material</td>
        <td>Description</td>
        <td>Cost</td>
        <td>Count</td>
    </tr>
    <tbody id=""vals""></tbody>
</table>

<div class=""row"">
    <div class=""col-md-4"">
        ");
            EndContext();
            BeginContext(340, 485, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81ee20d8496f4106abdb5d593493f541", async() => {
                BeginContext(359, 459, true);
                WriteLiteral(@"
            <div>Name</div>
            <input name=""Name"" class=""form-control"" />
            <div>Material</div>
            <input name=""Material"" class=""form-control"" />
            <div>Description</div>
            <input name=""Description"" class=""form-control"" />
            <div>Cost</div>
            <input name=""Cost"" class=""form-control"" />
            <div>Count</div>
            <input name=""Count"" class=""form-control"" />
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
            BeginContext(825, 107, true);
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Create\" class=\"sendForm btn btn-default\" />\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(955, 94, true);
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(_ => {\r\n            $.ajax({\r\n                url: \'");
                EndContext();
                BeginContext(1050, 30, false);
#line 43 "C:\Users\Lenovo\Desktop\Adam\IGI_6\IGI_6\Views\Home\Furniture.cshtml"
                 Write(Url.Action("furniture", "api"));

#line default
#line hidden
                EndContext();
                BeginContext(1080, 204, true);
                WriteLiteral("\',\r\n                type: \"GET\",\r\n                success: res => loadTable(res)\r\n            })\r\n        });\r\n       $(document).on(\"click\", \".del\", e => {\r\n\r\n            $.ajax({\r\n                url: \'");
                EndContext();
                BeginContext(1285, 30, false);
#line 51 "C:\Users\Lenovo\Desktop\Adam\IGI_6\IGI_6\Views\Home\Furniture.cshtml"
                 Write(Url.Action("furniture", "api"));

#line default
#line hidden
                EndContext();
                BeginContext(1315, 736, true);
                WriteLiteral(@"?id=' + e.target.id,
                type: ""DELETE"",
                success: res => loadTable(res)
            });
        });

        $(document).on(""click"", "".sendForm"", e => {
            var furniture = $(""#addForm"").serializeArray().reduce((prev, cur) => {
                if (prev != undefined)
                    prev[cur.name] = cur.value;
                else prev = { [cur.name]: cur.value };

                return prev;

            }, undefined);
            for (let val in furniture) {
                if (furniture[val] == """" || furniture[val] == null) {
                    alert(""Error"");
                    return;
                }
            }
            $.ajax({
                url: '");
                EndContext();
                BeginContext(2052, 32, false);
#line 73 "C:\Users\Lenovo\Desktop\Adam\IGI_6\IGI_6\Views\Home\Furniture.cshtml"
                 Write(Url.Action("addFurniture","api"));

#line default
#line hidden
                EndContext();
                BeginContext(2084, 929, true);
                WriteLiteral(@"',
                type: ""POST"",
                data: {
                    furniture: furniture
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
                                <td>${res[i].material}</td>
                                <td>${res[i].description}</td>
                                <td>${res[i].cost}</td>
                                <td>${res[i].count}</td>
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
