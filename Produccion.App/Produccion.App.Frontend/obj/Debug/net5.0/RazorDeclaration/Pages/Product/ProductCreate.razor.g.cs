// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Produccion.App.Frontend.Pages.Product
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/create_product")]
    public partial class ProductCreate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\gdnie\OneDrive\Desktop\Produccion.App\Produccion.App.Frontend\Pages\Product\ProductCreate.razor"
       
    Product product = new Product();
    async Task CreateProduct()
    {
        await Service.AddProduct(product);
        navManger.NavigateTo("/products");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IProductService Service { get; set; }
    }
}
#pragma warning restore 1591