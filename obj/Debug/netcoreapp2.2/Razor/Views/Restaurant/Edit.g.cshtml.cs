#pragma checksum "/home/daiane/Documentos/Projetos/dotnet-mvc-restaurant-solution/AppRestaurant/Views/Restaurant/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "848892cef61a7a05f0fd5e8a00fbd4c36ac05077"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurant_Edit), @"mvc.1.0.view", @"/Views/Restaurant/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurant/Edit.cshtml", typeof(AspNetCore.Views_Restaurant_Edit))]
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
#line 1 "/home/daiane/Documentos/Projetos/dotnet-mvc-restaurant-solution/AppRestaurant/Views/_ViewImports.cshtml"
using AppRestaurant;

#line default
#line hidden
#line 2 "/home/daiane/Documentos/Projetos/dotnet-mvc-restaurant-solution/AppRestaurant/Views/_ViewImports.cshtml"
using AppRestaurant.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"848892cef61a7a05f0fd5e8a00fbd4c36ac05077", @"/Views/Restaurant/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a5f84274a760ef2b80c9e6cf2dd857b82b6f8c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Restaurant_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppRestaurant.Models.Restaurant>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(40, 35, true);
            WriteLiteral("\n<div class=\"form-horizontal\">\n    ");
            EndContext();
            BeginContext(75, 1038, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "848892cef61a7a05f0fd5e8a00fbd4c36ac050774073", async() => {
                BeginContext(109, 40, true);
                WriteLiteral("\n\n        <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 149, "\"", 166, 1);
#line 6 "/home/daiane/Documentos/Projetos/dotnet-mvc-restaurant-solution/AppRestaurant/Views/Restaurant/Edit.cshtml"
WriteAttributeValue("", 157, Model.id, 157, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(167, 136, true);
                WriteLiteral("/>   \n\n        <div class=\"form-group\">\n            <label>Name</label>\n            <input  class=\"form-control\" type=\"text\" name=\"name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 303, "\"", 322, 1);
#line 10 "/home/daiane/Documentos/Projetos/dotnet-mvc-restaurant-solution/AppRestaurant/Views/Restaurant/Edit.cshtml"
WriteAttributeValue("", 311, Model.name, 311, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(323, 154, true);
                WriteLiteral("/>\n        </div>\n\n        <div class=\"form-group\">\n            <label>Address</label>\n            <input  class=\"form-control\" type=\"text\" name=\"address\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 477, "\"", 499, 1);
#line 15 "/home/daiane/Documentos/Projetos/dotnet-mvc-restaurant-solution/AppRestaurant/Views/Restaurant/Edit.cshtml"
WriteAttributeValue("", 485, Model.address, 485, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(500, 152, true);
                WriteLiteral("/>\n        </div>\n\n        <div class=\"form-group\">\n            <label>Number</label>\n            <input  class=\"form-control\" type=\"text\" name=\"number\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 652, "\"", 673, 1);
#line 20 "/home/daiane/Documentos/Projetos/dotnet-mvc-restaurant-solution/AppRestaurant/Views/Restaurant/Edit.cshtml"
WriteAttributeValue("", 660, Model.number, 660, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(674, 148, true);
                WriteLiteral("/>\n        </div>\n\n        <div class=\"form-group\">\n            <label>City</label>\n            <input  class=\"form-control\" type=\"text\" name=\"city\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 822, "\"", 841, 1);
#line 25 "/home/daiane/Documentos/Projetos/dotnet-mvc-restaurant-solution/AppRestaurant/Views/Restaurant/Edit.cshtml"
WriteAttributeValue("", 830, Model.city, 830, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(842, 150, true);
                WriteLiteral("/>\n        </div>\n\n        <div class=\"form-group\">\n            <label>State</label>\n            <input  class=\"form-control\" type=\"text\" name=\"state\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 992, "\"", 1012, 1);
#line 30 "/home/daiane/Documentos/Projetos/dotnet-mvc-restaurant-solution/AppRestaurant/Views/Restaurant/Edit.cshtml"
WriteAttributeValue("", 1000, Model.state, 1000, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1013, 93, true);
                WriteLiteral("/>\n        </div>\n\n        <input  class=\"btn btn-primary\" type=\"submit\" value=\"Save\"/>\n\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1113, 7, true);
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppRestaurant.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
