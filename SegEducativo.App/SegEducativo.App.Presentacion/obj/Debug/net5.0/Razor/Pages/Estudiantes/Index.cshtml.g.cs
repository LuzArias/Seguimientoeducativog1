#pragma checksum "C:\Educativo\SegEducativo.App\SegEducativo.App.Presentacion\Pages\Estudiantes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a514a2ab517c484aa1ad86952916910e4614c9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SegEducativo.App.Presentacion.Pages.Estudiantes.Pages_Estudiantes_Index), @"mvc.1.0.razor-page", @"/Pages/Estudiantes/Index.cshtml")]
namespace SegEducativo.App.Presentacion.Pages.Estudiantes
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
#line 1 "C:\Educativo\SegEducativo.App\SegEducativo.App.Presentacion\Pages\_ViewImports.cshtml"
using SegEducativo.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a514a2ab517c484aa1ad86952916910e4614c9d", @"/Pages/Estudiantes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d6defbce2b79a03ec6c5c56c2fdce98ee7c3232", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Estudiantes_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<h1> Esta es una lista de Estudiantes</h1>
<table class=""table"">
 <thead>
        <tr>
             <th scope=""col""> Nombre</th>
             <th scope=""col""> Apellidos</th>
              <th scope=""col"">Direccion</th>
              <th scope=""col""> Ciudad</th>
              <th scope=""col""> Correo</th>
             <th scope=""col""> Celular</th>
             <th scope=""col""> Genero</th>
             
        </tr>
 </thead>
 <label asp-form=""z.Nombre""></label>

 <!-- ");
#nullable restore
#line 23 "C:\Educativo\SegEducativo.App\SegEducativo.App.Presentacion\Pages\Estudiantes\Index.cshtml"
       foreach (var p in Model.estudiante)
      
  
 {

#line default
#line hidden
#nullable disable
            WriteLiteral("     <tr>\r\n         <td> ");
#nullable restore
#line 28 "C:\Educativo\SegEducativo.App\SegEducativo.App.Presentacion\Pages\Estudiantes\Index.cshtml"
         Write(p.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n         <td> ");
#nullable restore
#line 29 "C:\Educativo\SegEducativo.App\SegEducativo.App.Presentacion\Pages\Estudiantes\Index.cshtml"
         Write(p.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td> ");
#nullable restore
#line 30 "C:\Educativo\SegEducativo.App\SegEducativo.App.Presentacion\Pages\Estudiantes\Index.cshtml"
         Write(p.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td> ");
#nullable restore
#line 31 "C:\Educativo\SegEducativo.App\SegEducativo.App.Presentacion\Pages\Estudiantes\Index.cshtml"
         Write(p.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n         <td> ");
#nullable restore
#line 32 "C:\Educativo\SegEducativo.App\SegEducativo.App.Presentacion\Pages\Estudiantes\Index.cshtml"
         Write(p.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n         <td> ");
#nullable restore
#line 33 "C:\Educativo\SegEducativo.App\SegEducativo.App.Presentacion\Pages\Estudiantes\Index.cshtml"
         Write(p.Celular);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td> ");
#nullable restore
#line 34 "C:\Educativo\SegEducativo.App\SegEducativo.App.Presentacion\Pages\Estudiantes\Index.cshtml"
         Write(p.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>           \r\n         \r\n     </tr>\r\n");
#nullable restore
#line 37 "C:\Educativo\SegEducativo.App\SegEducativo.App.Presentacion\Pages\Estudiantes\Index.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n--> </table>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SegEducativo.App.Presentacion.Pages.Estudiantes.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SegEducativo.App.Presentacion.Pages.Estudiantes.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SegEducativo.App.Presentacion.Pages.Estudiantes.IndexModel>)PageContext?.ViewData;
        public SegEducativo.App.Presentacion.Pages.Estudiantes.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
