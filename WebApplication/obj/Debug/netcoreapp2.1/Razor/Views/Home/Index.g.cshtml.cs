#pragma checksum "C:\Users\ThangVyNam\source\repos\1512341-1512368-1512408\WebApplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be26a2c8d9bf03a8b0485d55fe72289233c88aaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\ThangVyNam\source\repos\1512341-1512368-1512408\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#line 2 "C:\Users\ThangVyNam\source\repos\1512341-1512368-1512408\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be26a2c8d9bf03a8b0485d55fe72289233c88aaa", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Home/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ThangVyNam\source\repos\1512341-1512368-1512408\WebApplication\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(82, 2190, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2c1697525464f8e8662e5d260a58149", async() => {
                BeginContext(88, 2177, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" type=""text/css"" href=""assets/css/bootstrap.css"">
    <!-- Website CSS style -->
    <link rel=""stylesheet"" type=""text/css"" href=""assets/css/main.css"">
    <!-- Website Font style -->
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.6.1/css/font-awesome.min.css"">

    <!-- Google Fonts -->
    <link href='https://fonts.googleapis.com/css?family=Passion+One' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Oxygen' rel='stylesheet' type='text/css'>
    <title>Admin</title>
    <style>
        body, html {
            height: 100%;
            background-repeat: no-repeat;
            background-color: #d3d3d3;
            font-family: 'Oxygen', sans-serif;
        }

        .main {
            margin-top: 70px;
        }

        h1.title {
            font-size: 50px;
            font-family: 'Passion One', cursive");
                WriteLiteral(@";
            font-weight: 400;
        }

        hr {
            width: 10%;
            color: #fff;
        }

        .form-group {
            margin-bottom: 15px;
        }

        label {
            margin-bottom: 15px;
        }

        input,
        input::-webkit-input-placeholder {
            font-size: 11px;
            padding-top: 3px;
        }

        .main-login {
            background-color: #fff;
            /* shadows and rounded borders */
            -moz-border-radius: 2px;
            -webkit-border-radius: 2px;
            border-radius: 2px;
            -moz-box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.3);
            -webkit-box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.3);
            box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.3);
        }

        .main-center {
            margin-top: 30px;
            margin: 0 auto;
            max-width: 330px;
            padding: 40px 40px;
        }

        .login-button {
            margin-top: 5px;");
                WriteLiteral("\n        }\r\n\r\n        .login-register {\r\n            font-size: 11px;\r\n            text-align: center;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2272, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2274, 3808, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "543fd688f2ca4ed080c6461fd320a8c9", async() => {
                BeginContext(2280, 357, true);
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row main"">
            <div class=""panel-heading"">
                <div class=""panel-title text-center"">
                    <h1 class=""title"">VNG Corporation</h1>
                    <hr />
                </div>
            </div>
            <div class=""main-login main-center"">
                ");
                EndContext();
                BeginContext(2637, 3313, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "883f225d30d345f99d44569abd23295b", async() => {
                    BeginContext(2702, 3241, true);
                    WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""name"" class=""cols-sm-2 control-label"">Your Name</label>
                        <div class=""cols-sm-10"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""fa fa-user fa"" aria-hidden=""true""></i></span>
                                <input type=""text"" class=""form-control"" name=""name"" id=""name"" placeholder=""Enter your Name"" />
                            </div>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label for=""email"" class=""cols-sm-2 control-label"">Your Email</label>
                        <div class=""cols-sm-10"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""fa fa-envelope fa"" aria-hidden=""true""></i></span>
                                <input type=""text"" class=""form");
                    WriteLiteral(@"-control"" name=""email"" id=""email"" placeholder=""Enter your Email"" />
                            </div>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label for=""username"" class=""cols-sm-2 control-label"">Username</label>
                        <div class=""cols-sm-10"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""fa fa-users fa"" aria-hidden=""true""></i></span>
                                <input type=""text"" class=""form-control"" name=""username"" id=""username"" placeholder=""Enter your Username"" />
                            </div>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label for=""password"" class=""cols-sm-2 control-label"">Password</label>
                        <div class=""cols-sm-10"">
                            <div class=""input-group"">
       ");
                    WriteLiteral(@"                         <span class=""input-group-addon""><i class=""fa fa-lock fa-lg"" aria-hidden=""true""></i></span>
                                <input type=""password"" class=""form-control"" name=""password"" id=""password"" placeholder=""Enter your Password"" />
                            </div>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label for=""confirm"" class=""cols-sm-2 control-label"">Confirm Password</label>
                        <div class=""cols-sm-10"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""fa fa-lock fa-lg"" aria-hidden=""true""></i></span>
                                <input type=""password"" class=""form-control"" name=""confirm"" id=""confirm"" placeholder=""Confirm your Password"" />
                            </div>
                        </div>
                    </div>
                    <div class=""form-group "">
  ");
                    WriteLiteral("                      <input type=\"submit\" class=\"btn btn-primary btn-lg btn-block login-button\">Register</input>\r\n                    </div>\r\n        \r\n                ");
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
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5950, 125, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <script type=\"text/javascript\" src=\"assets/js/bootstrap.js\"></script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6082, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
