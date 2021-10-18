#pragma checksum "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\Pages\Customers\CustomerUpdate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efbaee18710f7ae494a99c616395fbfb2aa6f464"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/update_customer/{id}")]
    public partial class CustomerUpdate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Actualizar Cliente</h3>\r\n\r\n");
            __builder.OpenComponent<Produccion.App.Frontend.Pages.Customers.Form>(1);
            __builder.AddAttribute(2, "ButtonText", "Actualizar Cliente");
            __builder.AddAttribute(3, "customer", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Produccion.App.Domain.Customer>(
#nullable restore
#line 6 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\Pages\Customers\CustomerUpdate.razor"
                                                 customer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\Pages\Customers\CustomerUpdate.razor"
                            UpdateCustomer

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\Pages\Customers\CustomerUpdate.razor"
       
    [Parameter]
    public string Id { get; set; }

    Customer customer = new Customer();
    
    protected async override Task OnParametersSetAsync()
    {
       customer = await Service.GetCustomer(int.Parse(Id));
    }
    async Task UpdateCustomer()
    {
        await Service.UpdateCustomer(customer);
        navManager.NavigateTo("/customers");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.ICustomerService Service { get; set; }
    }
}
#pragma warning restore 1591