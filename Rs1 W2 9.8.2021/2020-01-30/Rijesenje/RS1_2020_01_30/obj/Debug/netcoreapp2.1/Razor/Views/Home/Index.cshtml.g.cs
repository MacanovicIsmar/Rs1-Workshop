#pragma checksum "C:\Users\Ismar\Desktop\Rs1 W2 9.8.2021\2020-01-30\Postavka\RS1_2020_01_30\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86b4deb6cf2a2ea686580f125211e042f7fb7054"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86b4deb6cf2a2ea686580f125211e042f7fb7054", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0f6eb31d1c8637546d58ee5a6164dbc58c0c748", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Users\Ismar\Desktop\Rs1 W2 9.8.2021\2020-01-30\Postavka\RS1_2020_01_30\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Index";



#line default
#line hidden
            BeginContext(37, 55, true);
            WriteLiteral("\n<h2>\n    Ovdje upisati broj indeksa!!\n</h2>\n\n\n\n<br />\n");
            EndContext();
            BeginContext(93, 49, false);
#line 15 "C:\Users\Ismar\Desktop\Rs1 W2 9.8.2021\2020-01-30\Postavka\RS1_2020_01_30\Views\Home\Index.cshtml"
Write(Html.ActionLink("Ajax text", "Index", "AjaxTest"));

#line default
#line hidden
            EndContext();
            BeginContext(142, 8, true);
            WriteLiteral("\n<br />\n");
            EndContext();
            BeginContext(151, 44, false);
#line 17 "C:\Users\Ismar\Desktop\Rs1 W2 9.8.2021\2020-01-30\Postavka\RS1_2020_01_30\Views\Home\Index.cshtml"
Write(Html.ActionLink("DB text", "TestDB", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(195, 109, true);
            WriteLiteral("   << -- Prije nego što kliknete prepravite Connection string. Upišite vaš broj indeksa u naziv DB-a.\n<br />\n");
            EndContext();
            BeginContext(305, 58, false);
#line 19 "C:\Users\Ismar\Desktop\Rs1 W2 9.8.2021\2020-01-30\Postavka\RS1_2020_01_30\Views\Home\Index.cshtml"
Write(Html.ActionLink("Takmicenje/Index", "Index", "Takmicenje"));

#line default
#line hidden
            EndContext();
            BeginContext(363, 31, true);
            WriteLiteral(" << -- Potrebno implementirati!");
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
