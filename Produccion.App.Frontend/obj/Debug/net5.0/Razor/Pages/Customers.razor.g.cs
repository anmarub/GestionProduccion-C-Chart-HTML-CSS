#pragma checksum "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\Customers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "262e902933caa3785b93fdb96e5ae8b18471cc39"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/customers")]
    public partial class Customers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card bg-light mb-3");
            __builder.AddAttribute(2, "style", "width:auto");
            __builder.AddAttribute(3, "b-8bhqdjqbnl");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddAttribute(6, "b-8bhqdjqbnl");
            __builder.AddMarkupContent(7, "<h5 class=\"card-title\" b-8bhqdjqbnl>Clientes</h5>\r\n        ");
            __builder.OpenElement(8, "form");
            __builder.AddAttribute(9, "b-8bhqdjqbnl");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "form-row");
            __builder.AddAttribute(12, "b-8bhqdjqbnl");
            __builder.AddMarkupContent(13, "<div b-8bhqdjqbnl><a class=\"btn btn-primary\" href=\"/addCustomer\" b-8bhqdjqbnl>Nuevo </a>\r\n                    <button class=\"btn btn-primary\" b-8bhqdjqbnl>Buscar</button></div>\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-md-4");
            __builder.AddAttribute(16, "b-8bhqdjqbnl");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "id", "useIndividualParams");
            __builder.AddAttribute(20, "maxlength", 
#nullable restore
#line 14 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\Customers.razor"
                                                                                     maxlength

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "placeholder", 
#nullable restore
#line 14 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\Customers.razor"
                                                                                                              placeholder

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "required", 
#nullable restore
#line 14 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\Customers.razor"
                                                                                                                                      required

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "size", 
#nullable restore
#line 14 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\Customers.razor"
                                                                                                                                                       size

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "b-8bhqdjqbnl");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\Customers.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "<p b-8bhqdjqbnl><em b-8bhqdjqbnl>Loading...</em></p>");
#nullable restore
#line 24 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\Customers.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "card bg-light mb-3");
            __builder.AddAttribute(28, "style", "width:auto");
            __builder.AddAttribute(29, "b-8bhqdjqbnl");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "card-body");
            __builder.AddAttribute(32, "b-8bhqdjqbnl");
            __builder.OpenElement(33, "table");
            __builder.AddAttribute(34, "class", "table");
            __builder.AddAttribute(35, "b-8bhqdjqbnl");
            __builder.AddMarkupContent(36, @"<thead b-8bhqdjqbnl><tr b-8bhqdjqbnl><th b-8bhqdjqbnl>Date</th>
                        <th b-8bhqdjqbnl>Temp. (C)</th>
                        <th b-8bhqdjqbnl>Temp. (F)</th>
                        <th b-8bhqdjqbnl>Summary</th>
                        <th b-8bhqdjqbnl>Options</th></tr></thead>
                ");
            __builder.OpenElement(37, "tbody");
            __builder.AddAttribute(38, "b-8bhqdjqbnl");
#nullable restore
#line 40 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\Customers.razor"
                     foreach (var forecast in forecasts)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "tr");
            __builder.AddAttribute(40, "b-8bhqdjqbnl");
            __builder.OpenElement(41, "td");
            __builder.AddAttribute(42, "b-8bhqdjqbnl");
            __builder.AddContent(43, 
#nullable restore
#line 43 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\Customers.razor"
                                 forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                            ");
            __builder.OpenElement(45, "td");
            __builder.AddAttribute(46, "b-8bhqdjqbnl");
            __builder.AddContent(47, 
#nullable restore
#line 44 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\Customers.razor"
                                 forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                            ");
            __builder.OpenElement(49, "td");
            __builder.AddAttribute(50, "b-8bhqdjqbnl");
            __builder.AddContent(51, 
#nullable restore
#line 45 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\Customers.razor"
                                 forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                            ");
            __builder.OpenElement(53, "td");
            __builder.AddAttribute(54, "b-8bhqdjqbnl");
            __builder.AddContent(55, 
#nullable restore
#line 46 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\Customers.razor"
                                 forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                            ");
            __builder.AddMarkupContent(57, @"<td b-8bhqdjqbnl><a class=""btn btn-warning btn-sm"" b-8bhqdjqbnl><span type=""button"" aria-label=""Left Align"" class=""oi oi-pencil iconLines"" aria-hidden=""true"" b-8bhqdjqbnl></span></a> 
                     󠀠󠀠󠀠󠀠           <a class=""btn btn-danger btn-sm"" b-8bhqdjqbnl><span type=""button"" aria-label=""Left Align"" class=""oi oi-circle-x iconLines"" aria-hidden=""true"" b-8bhqdjqbnl></span></a></td>");
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\Customers.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\Customers.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\Customers.razor"
       
    private WeatherForecast[] forecasts;
    private String maxlength = "10";
    private string placeholder = "Buscar Cliente";
    private string required = "required";
    private string size = "20";

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

        private Dictionary<string, object> InputAttributes { get; set; } =
        new()
        {
            { "maxlength", "10" },
            { "placeholder", "Buscar Cliente" },
            { "required", "required" },
            { "size", "20" }
        };

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
