#pragma checksum "C:\Users\Lenovo\Desktop\Adam\IGI_6\IGI_6\Views\Home\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e93ed9d42d7e7c3d3917bb178e83111c6192852d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Order), @"mvc.1.0.view", @"/Views/Home/Order.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Order.cshtml", typeof(AspNetCore.Views_Home_Order))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e93ed9d42d7e7c3d3917bb178e83111c6192852d", @"/Views/Home/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14675d5b518b11293ea926fdd10875a2772f4a9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\Lenovo\Desktop\Adam\IGI_6\IGI_6\Views\Home\Order.cshtml"
  
    ViewData["Title"] = "Order";

#line default
#line hidden
            BeginContext(41, 370, true);
            WriteLiteral(@"
<h2>Order</h2>


<table class=""table"">
    <tr>
        <td>OrderDate</td>
        <td>IsOrderComplete</td>
        <td>Discount</td>
        <td>Count</td>
        <td>Client name</td>
        <td>Furniture name</td>
        <td>Worker name</td>
    </tr>
    <tbody id=""vals""></tbody>
</table>

<div class=""row"">
    <div class=""col-md-4"">
        ");
            EndContext();
            BeginContext(411, 1181, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a0a45e25d654e939f02d42249bd3730", async() => {
                BeginContext(430, 447, true);
                WriteLiteral(@"
            <div>OrderDate</div>
            <input name=""OrderDate"" class=""form-control"" />
            <div>IsOrderComplete</div>
            <input type=""checkbox"" name=""IsOrderComplete"" class=""form-control"" />
            <div>Discount</div>
            <input name=""Discount"" class=""form-control"" />
            <div>Count</div>
            <input name=""Count"" class=""form-control"" />
            <div>ClientName</div>
            ");
                EndContext();
                BeginContext(878, 191, false);
#line 33 "C:\Users\Lenovo\Desktop\Adam\IGI_6\IGI_6\Views\Home\Order.cshtml"
       Write(Html.DropDownList("clientName", new SelectList(new[] { "Simon Stivenson", "John Tomson", "Panny Johnson", "Homer Garrison", "Carl Tomson" }), null, new { @class = "form-control clientName" }));

#line default
#line hidden
                EndContext();
                BeginContext(1069, 52, true);
                WriteLiteral("\r\n            <div>FurnitureName</div>\r\n            ");
                EndContext();
                BeginContext(1122, 206, false);
#line 35 "C:\Users\Lenovo\Desktop\Adam\IGI_6\IGI_6\Views\Home\Order.cshtml"
       Write(Html.DropDownList("furnitureName", new SelectList(new[] { "Carlson x10670", "Johnson x61968", "Stivenson x30819", "Simonson x43960", "Carlson x69214" }), null, new { @class = "form-control furnitureName" }));

#line default
#line hidden
                EndContext();
                BeginContext(1328, 49, true);
                WriteLiteral("\r\n            <div>WorkerName</div>\r\n            ");
                EndContext();
                BeginContext(1378, 197, false);
#line 37 "C:\Users\Lenovo\Desktop\Adam\IGI_6\IGI_6\Views\Home\Order.cshtml"
       Write(Html.DropDownList("workerName", new SelectList(new[] { "Garry Tomson", "George Lennison", "Lenny Stivenson", "Simon Stivenson", "George Tomson" }), null, new { @class = "form-control workerName" }));

#line default
#line hidden
                EndContext();
                BeginContext(1575, 10, true);
                WriteLiteral("\r\n        ");
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
            BeginContext(1592, 107, true);
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Create\" class=\"sendForm btn btn-default\" />\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1722, 96, true);
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(_ => {\r\n\r\n            $.ajax({\r\n                url: \'");
                EndContext();
                BeginContext(1819, 26, false);
#line 50 "C:\Users\Lenovo\Desktop\Adam\IGI_6\IGI_6\Views\Home\Order.cshtml"
                 Write(Url.Action("order", "api"));

#line default
#line hidden
                EndContext();
                BeginContext(1845, 206, true);
                WriteLiteral("\',\r\n                type: \"GET\",\r\n                success: res => loadTable(res)\r\n            })\r\n        });\r\n\r\n       $(document).on(\"click\", \".del\", e => {\r\n\r\n            $.ajax({\r\n                url: \'");
                EndContext();
                BeginContext(2052, 26, false);
#line 59 "C:\Users\Lenovo\Desktop\Adam\IGI_6\IGI_6\Views\Home\Order.cshtml"
                 Write(Url.Action("order", "api"));

#line default
#line hidden
                EndContext();
                BeginContext(2078, 728, true);
                WriteLiteral(@"?id=' + e.target.id,
                type: ""DELETE"",
                success: res => loadTable(res)
            });
        });

        $(document).on(""click"", "".sendForm"", e => {

            var order = $(""#addForm"").serializeArray().reduce((prev, cur) => {
                if (prev != undefined)
                    prev[cur.name] = cur.value;
                else prev = { [cur.name]: cur.value };

                return prev;

            }, undefined);


            for (let val in order) {
                if (order[val] == """" || order[val] == null) {
                    alert(""Error"");
                    return;
                }
            }

            $.ajax({
                url: '");
                EndContext();
                BeginContext(2807, 28, false);
#line 85 "C:\Users\Lenovo\Desktop\Adam\IGI_6\IGI_6\Views\Home\Order.cshtml"
                 Write(Url.Action("addOrder","api"));

#line default
#line hidden
                EndContext();
                BeginContext(2835, 1227, true);
                WriteLiteral(@"',
                type: ""POST"",
                data: {
                    order: order,
                    clientName: order.clientName,
                    furnitureName: order.furnitureName,
                    workerName: order.workerName
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
                                <td>${res[i].orderDate}</td>
                                <td>${res[i].isOrderComplete}</td>
                                <td>${res[i].discount}</td>
                                <td>${res[i].count}</td>
                                <td>${res[i].client.name}</td>
                                <td>${res[i].furniture.name}</td>
                                <td>${res[i]");
                WriteLiteral(".worker.name}</td>\r\n                                <td class=\"del\" id=\"${res[i].id}\">x</td>\r\n                            </tr>\r\n                            `);\r\n            }\r\n        }\r\n    </script>\r\n");
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
