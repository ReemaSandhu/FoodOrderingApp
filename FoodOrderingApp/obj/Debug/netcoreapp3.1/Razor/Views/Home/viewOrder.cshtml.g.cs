#pragma checksum "C:\Users\reema.sandhu\source\repos\FoodOrderingApp\FoodOrderingApp\Views\Home\viewOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "392d3d446380638e29e68878320f448b9e0a7046"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_viewOrder), @"mvc.1.0.view", @"/Views/Home/viewOrder.cshtml")]
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
#line 1 "C:\Users\reema.sandhu\source\repos\FoodOrderingApp\FoodOrderingApp\Views\_ViewImports.cshtml"
using FoodOrderingApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\reema.sandhu\source\repos\FoodOrderingApp\FoodOrderingApp\Views\_ViewImports.cshtml"
using FoodOrderingApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"392d3d446380638e29e68878320f448b9e0a7046", @"/Views/Home/viewOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5244825aeee04c1ba2e7f1b38d04fe5e45a4569", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_viewOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link href=""https://fonts.googleapis.com/css?family=Cormorant+Garamond:300,300i,400,400i,500,600i,700""
      rel=""stylesheet"">
<link href=""https://fonts.googleapis.com/css?family=Satisfy"" rel=""stylesheet"">

<!-- Animate.css -->
<link rel=""stylesheet"" href=""/css/animate.css"">
<!-- Icomoon Icon Fonts-->
<link rel=""stylesheet"" href=""/css/icomoon.css"">
<!-- Bootstrap  -->
<link rel=""stylesheet"" href=""/css/bootstrap.css"">
<!-- Flexslider  -->
<link rel=""stylesheet"" href=""/css/flexslider.css"">

<!-- Theme style  -->
<link rel=""stylesheet"" href=""/css/style.css"">
<link rel=""stylesheet"" href=""/css/custom-style.css"">
<!-- Modernizr JS -->
<script src=""/js/modernizr-2.6.2.min.js""></script>
<div id=""page"">
    <header id=""fh5co-header"" class=""fh5co-cover js-fullheight"" role=""banner"" style=""background-image: url(/Images/hero_1.jpg);"" data-stellar-background-ratio=""0.5"">
        <div class=""overlay""></div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12 text-center"">
    ");
            WriteLiteral(@"                <div class=""display-t js-fullheight"">
                        <div class=""display-tc js-fullheight animate-box"" data-animate-effect=""fadeIn"">
                            <h1>See <em>Your</em> Order</h1>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </header>
    <div class=""order-section"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-sm-4"">
                    <div class=""order-preview-img"">
                        <img src=""/Images/gallery_2.jpg"" alt=""Order Preview Image"" />
                    </div>
                </div>
                <div class=""col-sm-8"">
                    <div class=""product-content"">
                        <h1 itemprop=""name"" class=""product-title"">
                            Italian Sauce Mushroom
                        </h1>
                        <div class=""price-sku-brand-container"">
                            <div class=""product-sku"">
");
            WriteLiteral("                                <span class=\"sku-text\">Sku :</span>\n                                <span itemprop=\"sku\" class=\"sku\"> Italian Sauce Mushroom </span>\n                            </div>\n                            <div itemprop=\"offers\"");
            BeginWriteAttribute("itemscope", " itemscope=\"", 2335, "\"", 2347, 0);
            EndWriteAttribute();
            WriteLiteral(@" itemtype=""http://schema.org/Offer""
                                 class=""product-price-container"">
                                <span class=""price-title"">Price: </span>
                                <span class=""sale-price"">
                                    17.99
                                </span>
                                <meta itemprop=""price"" content=""100.00000"">
                                <meta itemprop=""priceCurrency"" content=""USD"">

                            </div>
                            <div class=""category-title"">
                                <span class=""cat-title"">Category: </span>
                                <span class=""cat-name"">
                                    <a href=""/yummy/index.php/gallery?filter_catid=12"">Starter</a>
                                </span>
                            </div>
                            <p>
                                <a href=""pay-order.html"" class=""btn btn-primary btn-outline automation-pay-order"">
           ");
            WriteLiteral(@"                         Pay Now
                                </a>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""gototop js-top"">
    <a href=""#"" class=""js-gotop""><i class=""icon-arrow-up22""></i></a>
</div>

<!-- jQuery -->
<script src=""/js/jquery.min.js""></script>
<!-- jQuery Easing -->
<script src=""/js/jquery.easing.1.3.js""></script>
<!-- Bootstrap -->
<script src=""/js/bootstrap.min.js""></script>
<!-- Waypoints -->
<script src=""/js/jquery.waypoints.min.js""></script>
<!-- Waypoints -->
<script src=""/js/jquery.stellar.min.js""></script>
<!-- Flexslider -->
<script src=""/js/jquery.flexslider-min.js""></script>
<!-- Main -->
<script src=""/js/main.js""></script>
");
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
