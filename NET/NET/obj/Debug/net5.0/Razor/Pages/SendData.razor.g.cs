#pragma checksum "C:\Users\CK2\source\repos\NET\NET\Pages\SendData.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "02ac487f58d6f982ea11e22086fe46be277f5e45ae873f22f26dc6a16731ed36"
// <auto-generated/>
#pragma warning disable 1591
namespace NET.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\CK2\source\repos\NET\NET\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CK2\source\repos\NET\NET\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CK2\source\repos\NET\NET\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CK2\source\repos\NET\NET\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CK2\source\repos\NET\NET\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\CK2\source\repos\NET\NET\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\CK2\source\repos\NET\NET\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\CK2\source\repos\NET\NET\_Imports.razor"
using NET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\CK2\source\repos\NET\NET\_Imports.razor"
using NET.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\CK2\source\repos\NET\NET\Pages\SendData.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CK2\source\repos\NET\NET\Pages\SendData.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/send-data")]
    public partial class SendData : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Send Data to Flask</h3>\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "placeholder", "Enter data to send");
            __builder.AddAttribute(3, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\CK2\source\repos\NET\NET\Pages\SendData.razor"
              inputData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => inputData = __value, inputData));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\CK2\source\repos\NET\NET\Pages\SendData.razor"
                  SendDataToFlask

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Send Data");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "p");
#nullable restore
#line 12 "C:\Users\CK2\source\repos\NET\NET\Pages\SendData.razor"
__builder.AddContent(11, responseMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\CK2\source\repos\NET\NET\Pages\SendData.razor"
       
    private string inputData;
    private string responseMessage;

    private async Task SendDataToFlask()
    {
        var data = new { Message = inputData };
        responseMessage = await DataService.SendDataAsync(data);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataService DataService { get; set; }
    }
}
#pragma warning restore 1591
