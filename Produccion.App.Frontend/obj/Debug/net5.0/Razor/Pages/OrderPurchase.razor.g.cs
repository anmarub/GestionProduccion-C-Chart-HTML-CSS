#pragma checksum "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\OrderPurchase.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ae05d9b4f0ced6a360cd11ee879aeb94ec21729"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/orderpurchase")]
    public partial class OrderPurchase : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card bg-light mb-3");
            __builder.AddAttribute(2, "style", "width:auto");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.AddMarkupContent(5, "<h5 class=\"card-title\">Ordenes de Compra</h5>\r\n        ");
            __builder.OpenElement(6, "form");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-row");
            __builder.AddMarkupContent(9, "<div><button class=\"btn btn-primary\">Nuevo</button>\r\n                    <button class=\"btn btn-primary\">Buscar</button></div>\r\n                ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-md-4");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "id", "useIndividualParams");
            __builder.AddAttribute(15, "maxlength", 
#nullable restore
#line 14 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\OrderPurchase.razor"
                                                                                     maxlength

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "placeholder", 
#nullable restore
#line 14 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\OrderPurchase.razor"
                                                                                                              placeholder

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "required", 
#nullable restore
#line 14 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\OrderPurchase.razor"
                                                                                                                                      required

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "size", 
#nullable restore
#line 14 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\OrderPurchase.razor"
                                                                                                                                                       size

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\OrderPurchase.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "<p><em>Loading...</em></p>");
#nullable restore
#line 24 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\OrderPurchase.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "card bg-light mb-3");
            __builder.AddAttribute(22, "style", "width:auto");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "card-body");
            __builder.OpenElement(25, "table");
            __builder.AddAttribute(26, "class", "table");
            __builder.AddMarkupContent(27, "<thead><tr><th>Date</th>\r\n                        <th>Temp. (C)</th>\r\n                        <th>Temp. (F)</th>\r\n                        <th>Summary</th></tr></thead>\r\n                ");
            __builder.OpenElement(28, "tbody");
#nullable restore
#line 39 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\OrderPurchase.razor"
                     foreach (var forecast in forecasts)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "tr");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 42 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\OrderPurchase.razor"
                                 forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                            ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 43 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\OrderPurchase.razor"
                                 forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                            ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 44 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\OrderPurchase.razor"
                                 forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                            ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 45 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\OrderPurchase.razor"
                                 forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\OrderPurchase.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\OrderPurchase.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\andres.rubiano\OneDrive\Project\ProyectoProduccion\GestionProduccion-C-Chart-HTML-CSS\Produccion.App.Frontend\Pages\OrderPurchase.razor"
       
    private WeatherForecast[] forecasts;
    private String maxlength = "10";
    private string placeholder = "Buscar Productos";
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
            { "placeholder", "Input placeholder text" },
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
