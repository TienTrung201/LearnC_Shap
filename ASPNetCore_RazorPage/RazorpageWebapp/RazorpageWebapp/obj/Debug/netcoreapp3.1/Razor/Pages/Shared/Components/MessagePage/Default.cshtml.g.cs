#pragma checksum "T:\Wep\learnCode\LearnAspnetcore\ASPNetCore_RazorPage\RazorpageWebapp\RazorpageWebapp\Pages\Shared\Components\MessagePage\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d461ff0527197692e148b24b9d260289fe8c777c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorpageWebapp.Pages.Shared.Components.MessagePage.Pages_Shared_Components_MessagePage_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/MessagePage/Default.cshtml")]
namespace RazorpageWebapp.Pages.Shared.Components.MessagePage
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
#line 1 "T:\Wep\learnCode\LearnAspnetcore\ASPNetCore_RazorPage\RazorpageWebapp\RazorpageWebapp\Pages\_ViewImports.cshtml"
using RazorpageWebapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "T:\Wep\learnCode\LearnAspnetcore\ASPNetCore_RazorPage\RazorpageWebapp\RazorpageWebapp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d461ff0527197692e148b24b9d260289fe8c777c", @"/Pages/Shared/Components/MessagePage/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d35ba9e6d9aa1d41d0183286a2d8cee63f48b8e7", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Shared_Components_MessagePage_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RazorpageWebapp.MessagePage.Message>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "T:\Wep\learnCode\LearnAspnetcore\ASPNetCore_RazorPage\RazorpageWebapp\RazorpageWebapp\Pages\Shared\Components\MessagePage\Default.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = @Model.title;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card m-4\">\r\n   <div class=\"card-header bg-danger text-light\">\r\n       <h4>");
#nullable restore
#line 8 "T:\Wep\learnCode\LearnAspnetcore\ASPNetCore_RazorPage\RazorpageWebapp\RazorpageWebapp\Pages\Shared\Components\MessagePage\Default.cshtml"
      Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n   </div>\r\n   <div class=\"card-body\">\r\n       ");
#nullable restore
#line 11 "T:\Wep\learnCode\LearnAspnetcore\ASPNetCore_RazorPage\RazorpageWebapp\RazorpageWebapp\Pages\Shared\Components\MessagePage\Default.cshtml"
  Write(Html.Raw(Model.htmlcontent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </div>\r\n   <div class=\"card-footer\">\r\n       Chuyển đến - <a");
            BeginWriteAttribute("href", " href=\"", 359, "\"", 384, 1);
#nullable restore
#line 14 "T:\Wep\learnCode\LearnAspnetcore\ASPNetCore_RazorPage\RazorpageWebapp\RazorpageWebapp\Pages\Shared\Components\MessagePage\Default.cshtml"
WriteAttributeValue("", 366, Model.urlredirect, 366, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "T:\Wep\learnCode\LearnAspnetcore\ASPNetCore_RazorPage\RazorpageWebapp\RazorpageWebapp\Pages\Shared\Components\MessagePage\Default.cshtml"
                                            Write(Model.urlredirect);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n   </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorpageWebapp.MessagePage.Message> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
