#pragma checksum "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\CustomerForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "715b0af1e762749ac3d495cda197363ac0bcb072"
// <auto-generated/>
#pragma warning disable 1591
namespace Produccion.App.Frontend.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\_Imports.razor"
using Produccion.App.Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\_Imports.razor"
using Produccion.App.Frontend.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addCustomer")]
    public partial class CustomerForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"card bg-light mb-3\" style=\"width:auto\"><div class=\"card-body\"><h5 class=\"card-title\">Clientes</h5>\r\n        <form><div class=\"form-row\"><form class=\"needs-validation\" novalidate><div class=\"form-row\"><div class=\"col-md-4 mb-3\"><label for=\"validationCustom01\">First name</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"validationCustom01\" placeholder=\"First name\" value=\"Mark\" required>\r\n                    <div class=\"valid-feedback\">\r\n                      Looks good!\r\n                    </div></div>\r\n                  <div class=\"col-md-4 mb-3\"><label for=\"validationCustom02\">Last name</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"validationCustom02\" placeholder=\"Last name\" value=\"Otto\" required>\r\n                    <div class=\"valid-feedback\">\r\n                      Looks good!\r\n                    </div></div>\r\n                  <div class=\"col-md-4 mb-3\"><label for=\"validationCustomUsername\">Username</label>\r\n                    <div class=\"input-group\"><div class=\"input-group-prepend\"><span class=\"input-group-text\" id=\"inputGroupPrepend\"></span></div>\r\n                      <input type=\"text\" class=\"form-control\" id=\"validationCustomUsername\" placeholder=\"Username\" aria-describedby=\"inputGroupPrepend\" required>\r\n                      <div class=\"invalid-feedback\">\r\n                        Please choose a username.\r\n                      </div></div></div></div>\r\n                <div class=\"form-row\"><div class=\"col-md-6 mb-3\"><label for=\"validationCustom03\">City</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"validationCustom03\" placeholder=\"City\" required>\r\n                    <div class=\"invalid-feedback\">\r\n                      Please provide a valid city.\r\n                    </div></div>\r\n                  <div class=\"col-md-3 mb-3\"><label for=\"validationCustom04\">State</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"validationCustom04\" placeholder=\"State\" required>\r\n                    <div class=\"invalid-feedback\">\r\n                      Please provide a valid state.\r\n                    </div></div>\r\n                  <div class=\"col-md-3 mb-3\"><label for=\"validationCustom05\">Zip</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"validationCustom05\" placeholder=\"Zip\" required>\r\n                    <div class=\"invalid-feedback\">\r\n                      Please provide a valid zip.\r\n                    </div></div></div>\r\n                <div class=\"form-group\"><div class=\"form-check\"><input class=\"form-check-input\" type=\"checkbox\" value id=\"invalidCheck\" required>\r\n                    <label class=\"form-check-label\" for=\"invalidCheck\">\r\n                      Agree to terms and conditions\r\n                    </label>\r\n                    <div class=\"invalid-feedback\">\r\n                      You must agree before submitting.\r\n                    </div></div></div>\r\n                <button class=\"btn btn-primary\" type=\"submit\">Submit form</button></form></div></form></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
