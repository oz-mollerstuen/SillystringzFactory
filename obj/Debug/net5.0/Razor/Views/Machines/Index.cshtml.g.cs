#pragma checksum "/Users/admin/Desktop/Factory/Factory/Views/Machines/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bc9fc5c7acadf3a557dd44d2a83d61411533f85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Machines_Index), @"mvc.1.0.view", @"/Views/Machines/Index.cshtml")]
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
#line 5 "/Users/admin/Desktop/Factory/Factory/Views/Machines/Index.cshtml"
using Factory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bc9fc5c7acadf3a557dd44d2a83d61411533f85", @"/Views/Machines/Index.cshtml")]
    #nullable restore
    public class Views_Machines_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/admin/Desktop/Factory/Factory/Views/Machines/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"form\">\n\n  <h2>Machines</h2>\n\n");
#nullable restore
#line 11 "/Users/admin/Desktop/Factory/Factory/Views/Machines/Index.cshtml"
   if (@Model.Count == 0)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>No machines have been added yet!</h3>\n");
#nullable restore
#line 14 "/Users/admin/Desktop/Factory/Factory/Views/Machines/Index.cshtml"
  } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n  <ul>\n");
#nullable restore
#line 17 "/Users/admin/Desktop/Factory/Factory/Views/Machines/Index.cshtml"
     foreach(Machine machine in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <p>");
#nullable restore
#line 19 "/Users/admin/Desktop/Factory/Factory/Views/Machines/Index.cshtml"
    Write(Html.ActionLink($"{machine.Name}", "Details", new { id = machine.MachineId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 20 "/Users/admin/Desktop/Factory/Factory/Views/Machines/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\n</div>");
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
