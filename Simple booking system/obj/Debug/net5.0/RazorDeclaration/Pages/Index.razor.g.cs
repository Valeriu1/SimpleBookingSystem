// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Simple_booking_system.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sarks\RiderProjects\Simple booking system\Simple booking system\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sarks\RiderProjects\Simple booking system\Simple booking system\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sarks\RiderProjects\Simple booking system\Simple booking system\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sarks\RiderProjects\Simple booking system\Simple booking system\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sarks\RiderProjects\Simple booking system\Simple booking system\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sarks\RiderProjects\Simple booking system\Simple booking system\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sarks\RiderProjects\Simple booking system\Simple booking system\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sarks\RiderProjects\Simple booking system\Simple booking system\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sarks\RiderProjects\Simple booking system\Simple booking system\_Imports.razor"
using Simple_booking_system;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sarks\RiderProjects\Simple booking system\Simple booking system\_Imports.razor"
using Simple_booking_system.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sarks\RiderProjects\Simple booking system\Simple booking system\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sarks\RiderProjects\Simple booking system\Simple booking system\Pages\Index.razor"
using Simple_booking_system.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sarks\RiderProjects\Simple booking system\Simple booking system\Pages\Index.razor"
using Simple_booking_system.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sarks\RiderProjects\Simple booking system\Simple booking system\Pages\Index.razor"
using Simple_booking_system.DataAccess;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "C:\Users\sarks\RiderProjects\Simple booking system\Simple booking system\Pages\Index.razor"
       
    private IList<Resource> resourcesToShow;
    private Booking booking { get; set; } = new Booking();

    private async Task<bool> AddBooking()
    {
       return await BookingService.AddBookingAsync(booking);
    }

    private async Task SubmitBooking()
    {
        bool status = await AddBooking();
        if ( status)
        {
            Snackbar.Configuration.PositionClass = Defaults.Classes.Position.TopCenter;
            Snackbar.Add("Booking successful!", Severity.Success);
        }
        else
        {
            Snackbar.Configuration.PositionClass = Defaults.Classes.Position.TopCenter;
            Snackbar.Add("Booking error!", Severity.Error);
        }
    }

  


    protected override async Task OnInitializedAsync()
    {
        resourcesToShow = await ResourceService.GetResourcesAsync();
    }


   


   




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookingService BookingService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IResourceService ResourceService { get; set; }
    }
}
#pragma warning restore 1591
