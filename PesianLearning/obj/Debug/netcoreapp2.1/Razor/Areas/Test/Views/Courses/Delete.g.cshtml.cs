#pragma checksum "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a38cd1337e066796e56b171132a5b5f4e2870ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Test_Views_Courses_Delete), @"mvc.1.0.view", @"/Areas/Test/Views/Courses/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Test/Views/Courses/Delete.cshtml", typeof(AspNetCore.Areas_Test_Views_Courses_Delete))]
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
#line 1 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\_ViewImports.cshtml"
using PesianLearning;

#line default
#line hidden
#line 2 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\_ViewImports.cshtml"
using ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a38cd1337e066796e56b171132a5b5f4e2870ce", @"/Areas/Test/Views/Courses/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba86c27a6b221d928e2def89a266e3633537d201", @"/Areas/Test/Views/_ViewImports.cshtml")]
    public class Areas_Test_Views_Courses_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(66, 146, true);
            WriteLiteral("\r\n\r\n\r\n<h3>آیا مطمئنید میخواهید حذف کنید ؟</h3>\r\n<div>\r\n    <h4>Course</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(213, 43, false);
#line 15 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TitleFa));

#line default
#line hidden
            EndContext();
            BeginContext(256, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(300, 39, false);
#line 18 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TitleFa));

#line default
#line hidden
            EndContext();
            BeginContext(339, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(383, 43, false);
#line 21 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TitleEn));

#line default
#line hidden
            EndContext();
            BeginContext(426, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(470, 39, false);
#line 24 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TitleEn));

#line default
#line hidden
            EndContext();
            BeginContext(509, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(553, 40, false);
#line 27 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(593, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(637, 36, false);
#line 30 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(673, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(717, 45, false);
#line 33 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(762, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(806, 41, false);
#line 36 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(847, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(891, 43, false);
#line 39 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(934, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(978, 39, false);
#line 42 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1061, 41, false);
#line 45 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Count));

#line default
#line hidden
            EndContext();
            BeginContext(1102, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1146, 37, false);
#line 48 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Count));

#line default
#line hidden
            EndContext();
            BeginContext(1183, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1227, 41, false);
#line 51 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Visit));

#line default
#line hidden
            EndContext();
            BeginContext(1268, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1312, 37, false);
#line 54 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Visit));

#line default
#line hidden
            EndContext();
            BeginContext(1349, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1393, 44, false);
#line 57 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1437, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1481, 46, false);
#line 60 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Category.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1527, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1571, 48, false);
#line 63 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CourseBefore));

#line default
#line hidden
            EndContext();
            BeginContext(1619, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1663, 49, false);
#line 66 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CourseBefore.Text));

#line default
#line hidden
            EndContext();
            BeginContext(1712, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1756, 46, false);
#line 69 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CourseType));

#line default
#line hidden
            EndContext();
            BeginContext(1802, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1846, 48, false);
#line 72 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CourseType.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1894, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1938, 47, false);
#line 75 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CourseState));

#line default
#line hidden
            EndContext();
            BeginContext(1985, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2029, 49, false);
#line 78 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CourseState.Title));

#line default
#line hidden
            EndContext();
            BeginContext(2078, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2122, 45, false);
#line 81 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.professor));

#line default
#line hidden
            EndContext();
            BeginContext(2167, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2211, 50, false);
#line 84 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.professor.Evidence));

#line default
#line hidden
            EndContext();
            BeginContext(2261, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2299, 221, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95f3cbf41920457f88837c12c15c12c0", async() => {
                BeginContext(2325, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2335, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3684b9fae9d344709cdfa6bba7b15975", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 89 "E:\Persian_Learning\PesianLearning\Areas\Test\Views\Courses\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2371, 81, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"حذف\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2452, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e738d74dc94840849fbbb022e587c4c9", async() => {
                    BeginContext(2497, 6, true);
                    WriteLiteral("بازگشت");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2507, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2520, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
