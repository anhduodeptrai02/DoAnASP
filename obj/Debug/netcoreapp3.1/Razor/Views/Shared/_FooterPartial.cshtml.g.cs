#pragma checksum "D:\CDTH18D\ASP\DoAn\DoAnASP.NET1\DoAnASP.NET1\Views\Shared\_FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7eaaad60c5867b6ad686d7dc4b916bdc55a46b1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FooterPartial), @"mvc.1.0.view", @"/Views/Shared/_FooterPartial.cshtml")]
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
#line 1 "D:\CDTH18D\ASP\DoAn\DoAnASP.NET1\DoAnASP.NET1\Views\_ViewImports.cshtml"
using DoAnASP.NET1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CDTH18D\ASP\DoAn\DoAnASP.NET1\DoAnASP.NET1\Views\_ViewImports.cshtml"
using DoAnASP.NET1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eaaad60c5867b6ad686d7dc4b916bdc55a46b1d", @"/Views/Shared/_FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e95040c72666455c4c7fefaf1a22b110a234ed40", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- footer -->
<div class=""footer"">
    <div class=""container"">
        <div class=""w3_footer_grids"">
            <div class=""col-md-3 w3_footer_grid"">
                <h3>Contact</h3>
                <p>Duis aute irure dolor in reprehenderit in voluptate velit esse.</p>
                <ul class=""address"">
                    <li><i class=""glyphicon glyphicon-map-marker"" aria-hidden=""true""></i>1234k Avenue, 4th block, <span>New York City.</span></li>
                    <li><i class=""glyphicon glyphicon-envelope"" aria-hidden=""true""></i><a href=""mailto:info@example.com"">info@example.com</a></li>
                    <li><i class=""glyphicon glyphicon-earphone"" aria-hidden=""true""></i>+1234 567 567</li>
                </ul>
            </div>
            <div class=""col-md-3 w3_footer_grid"">
                <h3>Information</h3>
                <ul class=""info"">
                    <li><a href=""about.html"">About Us</a></li>
                    <li><a href=""mail.html"">Contact Us</a></li>
       ");
            WriteLiteral(@"             <li><a href=""codes.html"">Short Codes</a></li>
                    <li><a href=""faq.html"">FAQ's</a></li>
                    <li><a href=""products.html"">Special Products</a></li>
                </ul>
            </div>
            <div class=""col-md-3 w3_footer_grid"">
                <h3>Category</h3>
                <ul class=""info"">
                    <li><a href=""products.html"">Mobiles</a></li>
                    <li><a href=""products1.html"">Laptops</a></li>
                    <li><a href=""products.html"">Purifiers</a></li>
                    <li><a href=""products1.html"">Wearables</a></li>
                    <li><a href=""products2.html"">Kitchen</a></li>
                </ul>
            </div>
            <div class=""col-md-3 w3_footer_grid"">
                <h3>Profile</h3>
                <ul class=""info"">
                    <li><a href=""index.html"">Home</a></li>
                    <li><a href=""products.html"">Today's Deals</a></li>
                </ul>
           ");
            WriteLiteral(@"     <h4>Follow Us</h4>
                <div class=""agileits_social_button"">
                    <ul>
                        <li><a href=""#"" class=""facebook""> </a></li>
                        <li><a href=""#"" class=""twitter""> </a></li>
                        <li><a href=""#"" class=""google""> </a></li>
                        <li><a href=""#"" class=""pinterest""> </a></li>
                    </ul>
                </div>
            </div>
            <div class=""clearfix""> </div>
        </div>
    </div>
    <div class=""footer-copy"">
        <div class=""footer-copy1"">
            <div class=""footer-copy-pos"">
                <a href=""#home1"" class=""scroll""><img src=""images/arrow.png"" alt="" "" class=""img-responsive"" /></a>
            </div>
        </div>
        <div class=""container"">
            <p>&copy; 2017 Electronic Store. All rights reserved | Design by <a href=""http://w3layouts.com/"">W3layouts</a></p>
        </div>
    </div>
</div>
<!-- //footer -->
<!-- cart-js -->
<script ");
            WriteLiteral(@"src=""js/minicart.js""></script>
<script>
        w3ls.render();

        w3ls.cart.on('w3sb_checkout', function (evt) {
        	var items, len, i;

        	if (this.subtotal() > 0) {
        		items = this.items();

        		for (i = 0, len = items.length; i < len; i++) {
        		}
        	}
        });
</script>
<!-- //cart-js -->   ");
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
