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
#line 6 "C:\Users\sarks\RiderProjects\Simple booking system\Simple booking system\Pages\Index.razor"
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
#line 97 "C:\Users\sarks\RiderProjects\Simple booking system\Simple booking system\Pages\Index.razor"
       
    private IList<Resource> resourcesToShow;
    private Booking booking { get; set; } = new Booking();

    private async Task<bool> AddBooking()
    {
       return await BookingService.AddBookingAsync(booking);
    }

  


    protected override async Task OnInitializedAsync()
    {
        resourcesToShow = await ResourceService.GetResourcesAsync();
    }


    // public void PopulateResourceTable()
    // {
    //     Resource resource = new Resource();
    //     resource.Name = "Truck";
    //     resource.Quantity = 5;
    //
    //     ResourceService.AddResourceAsync(resource);
    // }


    // <div class="modal" tabindex="-1" role="dialog" style="display: block">
    //     <div class="modal-dialog">
    //         <div class="modal-content">
    //             <div class="modal-header">
    //                 <h5 class="modal-title">Resource booking</h5>
    //                 <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close" @onclick="@ClosePopup"></button>
    //             </div>
    //             <div class="modal-body">
    //                 <p>Modal body text goes here.</p>
    //             </div>
    //             <div class="modal-footer">
    //                 <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
    //                 <button type="button" class="btn btn-primary">Save changes</button>
    //             </div>
    //         </div>
    //     </div>
    // </div>




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookingService BookingService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IResourceService ResourceService { get; set; }
    }
}
#pragma warning restore 1591