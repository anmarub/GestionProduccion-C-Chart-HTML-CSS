#pragma checksum "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\Pages\Customers\CustomerDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "847608a75e2fad9a4f0b3171666c315e4602f330"
// <auto-generated/>
#pragma warning disable 1591
namespace Produccion.App.Frontend.Pages.Customers
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\_Imports.razor"
using Produccion.App.Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\_Imports.razor"
using Produccion.App.Frontend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\_Imports.razor"
using Produccion.App.Frontend.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\_Imports.razor"
using Produccion.App.Domain;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/customer_details/{id}")]
    public partial class CustomerDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row justify content center m.3");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-sm-8");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
#nullable restore
#line 8 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\Pages\Customers\CustomerDetails.razor"
            if(customer!=null){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-header");
            __builder.OpenElement(8, "h1");
            __builder.AddContent(9, 
#nullable restore
#line 10 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\Pages\Customers\CustomerDetails.razor"
                     customer.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body text-center");
            __builder.OpenElement(13, "h4");
            __builder.AddContent(14, "Nit ID : ");
            __builder.AddContent(15, 
#nullable restore
#line 13 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\Pages\Customers\CustomerDetails.razor"
                              customer.identification

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "h4");
            __builder.AddContent(18, "Email : ");
            __builder.AddContent(19, 
#nullable restore
#line 14 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\Pages\Customers\CustomerDetails.razor"
                             customer.email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "h4");
            __builder.AddContent(22, "Direccion : ");
            __builder.AddContent(23, 
#nullable restore
#line 15 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\Pages\Customers\CustomerDetails.razor"
                                 customer.address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "h4");
            __builder.AddContent(26, "Direccion : ");
            __builder.AddContent(27, 
#nullable restore
#line 16 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\Pages\Customers\CustomerDetails.razor"
                                 customer.id_type_identification

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "card-footer text-center");
            __builder.AddMarkupContent(31, "<a class=\"btn btn-primary\" href=\"/customers\">Regresar</a>\r\n                ");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "class", "btn btn-primary");
            __builder.AddAttribute(34, "href", "update_customer/" + (
#nullable restore
#line 20 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\Pages\Customers\CustomerDetails.razor"
                                                                  customer.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn btn-danger");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\Pages\Customers\CustomerDetails.razor"
                                                         DeleteCustomer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Eliminar");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\Pages\Customers\CustomerDetails.razor"
           }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\Pages\Customers\CustomerDetails.razor"
       
    [Parameter]
    public string id { get; set; }
    public Customer customer { get; set; } = new Customer();

    protected override async Task OnInitializedAsync()
    {
        customer = await Service.GetCustomer(int.Parse(id));
    }

    protected async void DeleteCustomer()
    {
        await Service.DeleteCustomer(int.Parse(id));
        navManger.NavigateTo("/customers");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.ICustomerService Service { get; set; }
    }
}
#pragma warning restore 1591