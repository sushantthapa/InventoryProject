#pragma checksum "C:\Users\SUSHANT\Desktop\projects\C#\Inventory Project\IMSystem\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8663e8dba59bfe3dc7d88565cad079dc47efb12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\SUSHANT\Desktop\projects\C#\Inventory Project\IMSystem\Views\_ViewImports.cshtml"
using IMSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SUSHANT\Desktop\projects\C#\Inventory Project\IMSystem\Views\_ViewImports.cshtml"
using IMSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8663e8dba59bfe3dc7d88565cad079dc47efb12", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22815f4d6b6546d81b99fe37f2ce6d516114588b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\SUSHANT\Desktop\projects\C#\Inventory Project\IMSystem\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .carousel {
  width:50%;
  height:260px;
   margin: auto;
}
.carousel-item {
    height: 350px;
}

.carousel-indicators li {
  width: 10px;
  height: 10px;
  border-radius: 100%;
   background-color: #0000ff;
}
.carousel-indicators .active{
      background-color: #ffff99;
}
.carousel-indicators {
    bottom: -80px;
}

</style>

<div class=""bd-example"">
  <div id=""carouselExampleCaptions"" class=""carousel slide"" data-ride=""carousel"">
    <ol class=""carousel-indicators"">
      <li data-target=""#carouselExampleCaptions"" data-slide-to=""0"" class=""active""></li>
      <li data-target=""#carouselExampleCaptions"" data-slide-to=""1""></li>
      <li data-target=""#carouselExampleCaptions"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"">
      <div class=""carousel-item active"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d8663e8dba59bfe3dc7d88565cad079dc47efb125985", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"carousel-caption d-none d-md-block\">\r\n          <h5>First slide label</h5>\r\n          <p>Nulla vitae elit libero, a pharetra augue mollis interdum.</p>\r\n        </div>\r\n      </div>\r\n      <div class=\"carousel-item\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d8663e8dba59bfe3dc7d88565cad079dc47efb127444", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"carousel-caption d-none d-md-block\">\r\n          <h5>Second slide label</h5>\r\n          <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>\r\n        </div>\r\n      </div>\r\n      <div class=\"carousel-item\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d8663e8dba59bfe3dc7d88565cad079dc47efb128902", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <div class=""carousel-caption d-none d-md-block"">
          <h5>Third slide label</h5>
          <p>Praesent commodo cursus magna, vel scelerisque nisl consectetur.</p>
        </div>
      </div>
    </div>
    <a class=""carousel-control-prev"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""prev"">
      <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
      <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""next"">
      <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
      <span class=""sr-only"">Next</span>
    </a>
  </div>
</div>
<br>
<br>
<br>
<br>

<div class=""jumbotron "">
   <div class=""card-deck"">
  <div class=""card"">
    <img src=""..."" class=""card-img-top"" alt=""..."">
    <div class=""card-body"">
      <h5 class=""card-title"">Card title</h5>
      <p class=""card-text"">This is a wider card with supporting text below as a natural lead");
            WriteLiteral(@"-in to additional content. This content is a little bit longer.</p>
    </div>
    <p>
  <a class=""btn btn-primary"" data-toggle=""collapse"" href=""#collapseExample"" role=""button"" aria-expanded=""false"" aria-controls=""collapseExample"">
    product details
  </a>
  </p>
  <div class=""collapse"" id=""collapseExample"">
  <div class=""card card-body"">
    Product details goes here.
  </div>
</div>

    <div class=""card-footer"">
      <small class=""text-muted"">Last updated 3 mins ago</small>
    </div>
  </div>
  <div class=""card"">
    <img src=""..."" class=""card-img-top"" alt=""..."">
    <div class=""card-body"">
      <h5 class=""card-title"">Card title</h5>
      <p class=""card-text"">This card has supporting text below as a natural lead-in to additional content.</p>
    </div>
    <div class=""card-footer"">
      <small class=""text-muted"">Last updated 3 mins ago</small>
    </div>
  </div>
  <div class=""card"">
    <img src=""..."" class=""card-img-top"" alt=""..."">
    <div class=""card-body"">
      <h");
            WriteLiteral(@"5 class=""card-title"">Card title</h5>
      <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This card has even longer content than the first to show that equal height action.</p>
    </div>
    <div class=""card-footer"">
      <small class=""text-muted"">Last updated 3 mins ago</small>
    </div>
  </div>
  <div class=""card-deck"">
  <div class=""card"">
    <img src=""..."" class=""card-img-top"" alt=""..."">
    <div class=""card-body"">
      <h5 class=""card-title"">Card title</h5>
      <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
    </div>
    <div class=""card-footer"">
      <small class=""text-muted"">Last updated 3 mins ago</small>
    </div>
  </div>
  <div class=""card"">
    <img src=""..."" class=""card-img-top"" alt=""..."">
    <div class=""card-body"">
      <h5 class=""card-title"">Card title</h5>
      <p class=""card-text"">This c");
            WriteLiteral(@"ard has supporting text below as a natural lead-in to additional content.</p>
    </div>
    <div class=""card-footer"">
      <small class=""text-muted"">Last updated 3 mins ago</small>
    </div>
  </div>
  <div class=""card"">
    <img src=""..."" class=""card-img-top"" alt=""..."">
    <div class=""card-body"">
      <h5 class=""card-title"">Card title</h5>
      <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This card has even longer content than the first to show that equal height action.</p>
    </div>
    <div class=""card-footer"">
      <small class=""text-muted"">Last updated 3 mins ago</small>
    </div>
  </div>
</div>
</div>
<div class=""card-deck"">
  <div class=""card"">
    <img src=""..."" class=""card-img-top"" alt=""..."">
    <div class=""card-body"">
      <h5 class=""card-title"">Card title</h5>
      <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a li");
            WriteLiteral(@"ttle bit longer.</p>
    </div>
    <div class=""card-footer"">
      <small class=""text-muted"">Last updated 3 mins ago</small>
    </div>
  </div>
  <div class=""card"">
    <img src=""..."" class=""card-img-top"" alt=""..."">
    <div class=""card-body"">
      <h5 class=""card-title"">Card title</h5>
      <p class=""card-text"">This card has supporting text below as a natural lead-in to additional content.</p>
    </div>
    <div class=""card-footer"">
      <small class=""text-muted"">Last updated 3 mins ago</small>
    </div>
  </div>
  <div class=""card"">
    <img src=""..."" class=""card-img-top"" alt=""..."">
    <div class=""card-body"">
      <h5 class=""card-title"">Card title</h5>
      <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This card has even longer content than the first to show that equal height action.</p>
    </div>
    <div class=""card-footer"">
      <small class=""text-muted"">Last updated 3 mins ago</small>
    </div>
  </d");
            WriteLiteral("iv>\r\n</div>\r\n  \r\n</div>\r\n");
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
