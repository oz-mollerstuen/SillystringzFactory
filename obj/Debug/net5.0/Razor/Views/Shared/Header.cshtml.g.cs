#pragma checksum "/Users/admin/Desktop/Factory/Factory/Views/Shared/Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "700ddfa8f4b20d1d1b62c7a6c5e6f624c43d53b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Header), @"mvc.1.0.view", @"/Views/Shared/Header.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"700ddfa8f4b20d1d1b62c7a6c5e6f624c43d53b7", @"/Views/Shared/Header.cshtml")]
    #nullable restore
    public class Views_Shared_Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"header row\">\n  <div class=\"col-7\">\n    <h1>");
#nullable restore
#line 3 "/Users/admin/Desktop/Factory/Factory/Views/Shared/Header.cshtml"
   Write(Html.ActionLink("Dr. Sillystringz Factory", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>      \n  </div>\n  <div class=\"link col-5\">\n    ");
#nullable restore
#line 6 "/Users/admin/Desktop/Factory/Factory/Views/Shared/Header.cshtml"
Write(Html.ActionLink("Machines", "Index", "Machines"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  |  ");
#nullable restore
#line 6 "/Users/admin/Desktop/Factory/Factory/Views/Shared/Header.cshtml"
                                                     Write(Html.ActionLink("Engineers", "Index", "Engineers"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  |  ");
#nullable restore
#line 6 "/Users/admin/Desktop/Factory/Factory/Views/Shared/Header.cshtml"
                                                                                                             Write(Html.ActionLink("New Equipment", "Create", "Machines"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  |  ");
#nullable restore
#line 6 "/Users/admin/Desktop/Factory/Factory/Views/Shared/Header.cshtml"
                                                                                                                                                                         Write(Html.ActionLink("New Hires", "Create", "Engineers"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n  </div>\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
