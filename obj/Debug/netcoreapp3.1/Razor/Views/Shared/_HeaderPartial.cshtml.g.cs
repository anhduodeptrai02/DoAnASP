#pragma checksum "D:\DoAn31-12\DoAnASP\Views\Shared\_HeaderPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1030f4363efd9bc6c79d6c5a7da1fa24a5c1599d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HeaderPartial), @"mvc.1.0.view", @"/Views/Shared/_HeaderPartial.cshtml")]
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
#nullable restore
#line 1 "D:\DoAn31-12\DoAnASP\Views\_ViewImports.cshtml"
using DoAnASP.NET1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoAn31-12\DoAnASP\Views\_ViewImports.cshtml"
using DoAnASP.NET1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1030f4363efd9bc6c79d6c5a7da1fa24a5c1599d", @"/Views/Shared/_HeaderPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4813db430f0617430d49d6ea51f5fc3c09222976", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__HeaderPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("last"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral(@"	<!-- for bootstrap working -->
<script type=""text/javascript"" src=""js/bootstrap-3.1.1.min.js""></script>
<!-- //for bootstrap working -->
<!-- header modal -->
<div class=""modal fade"" id=""myModal88"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModal88""
     aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                    &times;
                </button>
                <h4 class=""modal-title"" id=""myModalLabel"">Don't Wait, Login now!</h4>
            </div>
            <div class=""modal-body modal-body-sub"">
                <div class=""row"">
                    <div class=""col-md-8 modal_body_left modal_body_left1"" style=""border-right: 1px dotted #C2C2C2;padding-right:3em;"">
                        <div class=""sap_tabs"">
                            <div id=""horizontalTab"" style=""display: block; width: 100%; margin: 0px;"">
     ");
            WriteLiteral(@"                           <ul>
                                    <li class=""resp-tab-item"" aria-controls=""tab_item-0""><span>Sign in</span></li>
                                    <li class=""resp-tab-item"" aria-controls=""tab_item-1""><span>Sign up</span></li>
                                </ul>
                                <div class=""tab-1 resp-tab-content"" aria-labelledby=""tab_item-0"">
                                    <div class=""facts"">
                                        <div class=""register"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1030f4363efd9bc6c79d6c5a7da1fa24a5c1599d5830", async() => {
                WriteLiteral("\n                                                <input name=\"Email\" placeholder=\"Email Address\" type=\"text\"");
                BeginWriteAttribute("required", " required=\"", 1724, "\"", 1735, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                                                <input name=\"Password\" placeholder=\"Password\" type=\"password\"");
                BeginWriteAttribute("required", " required=\"", 1847, "\"", 1858, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                <div class=""sign-up"">
                                                    <input type=""submit"" value=""Sign in"" />
                                                </div>
                                            ");
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
            WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                                <div class=""tab-2 resp-tab-content"" aria-labelledby=""tab_item-1"">
                                    <div class=""facts"">
                                        <div class=""register"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1030f4363efd9bc6c79d6c5a7da1fa24a5c1599d8559", async() => {
                WriteLiteral("\n                                                <input placeholder=\"Name\" name=\"Name\" type=\"text\"");
                BeginWriteAttribute("required", " required=\"", 2649, "\"", 2660, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                                                <input placeholder=\"Email Address\" name=\"Email\" type=\"email\"");
                BeginWriteAttribute("required", " required=\"", 2771, "\"", 2782, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                                                <input placeholder=\"Password\" name=\"Password\" type=\"password\"");
                BeginWriteAttribute("required", " required=\"", 2894, "\"", 2905, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                                                <input placeholder=\"Confirm Password\" name=\"Password\" type=\"password\"");
                BeginWriteAttribute("required", " required=\"", 3025, "\"", 3036, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                <div class=""sign-up"">
                                                    <input type=""submit"" value=""Create Account"" />
                                                </div>
                                            ");
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
            WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <script src=""js/easyResponsiveTabs.js"" type=""text/javascript""></script>
                        <script type=""text/javascript"">
                            $(document).ready(function () {
                                $('#horizontalTab').easyResponsiveTabs({
                                    type: 'default', //Types: default, vertical, accordion
                                    width: 'auto', //auto or any width like 600px
                                    fit: true   // 100% fit in a container
                                });
                            });
                        </script>
                        <div id=""OR"" class=""hidden-xs"">OR</div>
                    </div>
                    <div class=""col-md-4 modal_body_right modal_body_right1"">
                        ");
            WriteLiteral(@"<div class=""row text-center sign-with"">
                            <div class=""col-md-12"">
                                <h3 class=""other-nw"">Sign in with</h3>
                            </div>
                            <div class=""col-md-12"">
                                <ul class=""social"">
                                    <li class=""social_facebook""><a href=""#"" class=""entypo-facebook""></a></li>
                                    <li class=""social_dribbble""><a href=""#"" class=""entypo-dribbble""></a></li>
                                    <li class=""social_twitter""><a href=""#"" class=""entypo-twitter""></a></li>
                                    <li class=""social_behance""><a href=""#"" class=""entypo-behance""></a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script>
    $('#myModal88').modal('show');
</script>
<!-- header modal -->
<!--");
            WriteLiteral(@" header -->
<div class=""header"" id=""home1"">
    <div class=""container"">
        <div class=""w3l_login"">
            <a href=""#"" data-toggle=""modal"" data-target=""#myModal88""><span class=""glyphicon glyphicon-user"" aria-hidden=""true""></span></a>
        </div>
        <div class=""w3l_logo"">
            <h1><a href=""index.html"">Electronic Store<span>Your stores. Your place.</span></a></h1>
        </div>
        <div class=""search"">
            <input class=""search_box"" type=""checkbox"" id=""search_box"">
            <label class=""icon-search"" for=""search_box""><span class=""glyphicon glyphicon-search"" aria-hidden=""true""></span></label>
            <div class=""search_form"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1030f4363efd9bc6c79d6c5a7da1fa24a5c1599d14337", async() => {
                WriteLiteral("\n                    <input type=\"text\" name=\"Search\" placeholder=\"Search...\">\n                    <input type=\"submit\" value=\"Send\">\n                ");
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
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"cart cart box_1\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1030f4363efd9bc6c79d6c5a7da1fa24a5c1599d16098", async() => {
                WriteLiteral("\n                <input type=\"hidden\" name=\"cmd\" value=\"_cart\" />\n                <input type=\"hidden\" name=\"display\" value=\"1\" />\n                <button class=\"w3view-cart\" type=\"submit\" name=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 6571, "\"", 6579, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-cart-arrow-down\" aria-hidden=\"true\"></i></button>\n            ");
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
            WriteLiteral(@"
        </div>
    </div>
</div>
<!-- //header -->
<!-- navigation -->
<div class=""navigation"">
    <div class=""container"">
        <nav class=""navbar navbar-default"">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class=""navbar-header nav_2"">
                <button type=""button"" class=""navbar-toggle collapsed navbar-toggle1"" data-toggle=""collapse"" data-target=""#bs-megadropdown-tabs"">
                    <span class=""sr-only"">Toggle navigation</span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
            </div>
            <div class=""collapse navbar-collapse"" id=""bs-megadropdown-tabs"">
                <ul class=""nav navbar-nav"">
                    <li><a href=""index.html"" class=""act"">Home</a></li>
                    <!-- Mega Menu -->
                    <li class=""dropdown"">
                        <a href=""#"" class=""dropdow");
            WriteLiteral(@"n-toggle"" data-toggle=""dropdown"">Products <b class=""caret""></b></a>
                        <ul class=""dropdown-menu multi-column columns-3"">
                            <div class=""row"">
                                <div class=""col-sm-3"">
                                    <ul class=""multi-column-dropdown"">
                                        <h6>Mobiles</h6>
                                        <li><a href=""products.html"">Mobile Phones</a></li>
                                        <li><a href=""products.html"">Mp3 Players <span>New</span></a></li>
                                        <li><a href=""products.html"">Popular Models</a></li>
                                        <li><a href=""products.html"">All Tablets<span>New</span></a></li>
                                    </ul>
                                </div>
                                <div class=""col-sm-3"">
                                    <ul class=""multi-column-dropdown"">
                                        <h6>Accessor");
            WriteLiteral(@"ies</h6>
                                        <li><a href=""products1.html"">Laptop</a></li>
                                        <li><a href=""products1.html"">Desktop</a></li>
                                        <li><a href=""products1.html"">Wearables <span>New</span></a></li>
                                        <li><a href=""products1.html""><i>Summer Store</i></a></li>
                                    </ul>
                                </div>
                                <div class=""col-sm-2"">
                                    <ul class=""multi-column-dropdown"">
                                        <h6>Home</h6>
                                        <li><a href=""products2.html"">Tv</a></li>
                                        <li><a href=""products2.html"">Camera</a></li>
                                        <li><a href=""products2.html"">AC</a></li>
                                        <li><a href=""products2.html"">Grinders</a></li>
                                    </ul>
    ");
            WriteLiteral(@"                            </div>
                                <div class=""col-sm-4"">
                                    <div class=""w3ls_products_pos"">
                                        <h4>30%<i>Off/-</i></h4>
                                        <img src=""images/1.jpg"" alt="" "" class=""img-responsive"" />
                                    </div>
                                </div>
                                <div class=""clearfix""></div>
                            </div>
                        </ul>
                    </li>
                    <li><a href=""about.html"">About Us</a></li>
                    <li class=""w3pages"">
                        <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Pages <span class=""caret""></span></a>
                        <ul class=""dropdown-menu"">
                            <li><a href=""icons.html"">Web Icons</a></li>
                            <li><a href=""codes.html"">Short Codes");
            WriteLiteral(@"</a></li>
                        </ul>
                    </li>
                    <li><a href=""mail.html"">Mail Us</a></li>
                </ul>
            </div>
        </nav>
    </div>
</div>
<!-- //navigation -->
<!-- banner -->
<div class=""banner"">
    <div class=""container"">
        <h3>Electronic Store, <span>Special Offers</span></h3>
    </div>
</div>");
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
