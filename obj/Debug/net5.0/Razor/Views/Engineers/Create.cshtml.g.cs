#pragma checksum "/Users/admin/Desktop/Factory/Factory/Views/Engineers/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "832227d1791711716faaae5481b8ab55d3bff7ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Engineers_Create), @"mvc.1.0.view", @"/Views/Engineers/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"832227d1791711716faaae5481b8ab55d3bff7ba", @"/Views/Engineers/Create.cshtml")]
    #nullable restore
    public class Views_Engineers_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Engineer>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/admin/Desktop/Factory/Factory/Views/Engineers/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"form\">\n  <h4>Add a new Engineer</h4>\n\n");
#nullable restore
#line 10 "/Users/admin/Desktop/Factory/Factory/Views/Engineers/Create.cshtml"
   using (Html.BeginForm())
  {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/admin/Desktop/Factory/Factory/Views/Engineers/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/admin/Desktop/Factory/Factory/Views/Engineers/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Add Engineer\" class=\"btn btn-default\" />\n");
#nullable restore
#line 16 "/Users/admin/Desktop/Factory/Factory/Views/Engineers/Create.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Factory.Models.Engineer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
