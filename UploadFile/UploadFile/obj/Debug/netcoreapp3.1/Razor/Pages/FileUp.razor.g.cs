#pragma checksum "D:\Test Projects\UploadFile\UploadFile\Pages\FileUp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22b021a9360e35701cf17250638fe03d2c6eebee"
// <auto-generated/>
#pragma warning disable 1591
namespace UploadFile.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Test Projects\UploadFile\UploadFile\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Test Projects\UploadFile\UploadFile\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Test Projects\UploadFile\UploadFile\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Test Projects\UploadFile\UploadFile\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Test Projects\UploadFile\UploadFile\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Test Projects\UploadFile\UploadFile\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Test Projects\UploadFile\UploadFile\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Test Projects\UploadFile\UploadFile\_Imports.razor"
using UploadFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Test Projects\UploadFile\UploadFile\_Imports.razor"
using UploadFile.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FileUp")]
    public partial class FileUp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>FileUp</h3>\r\n\r\nChoose File: <input type=\"file\" id=\"myfile\">\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "type", "button");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\Test Projects\UploadFile\UploadFile\Pages\FileUp.razor"
                                                        JavaScript

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "\r\n    JS and Blazor\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "D:\Test Projects\UploadFile\UploadFile\Pages\FileUp.razor"
      

    public async Task  JavaScript()
    {
       var text  =  await JSRuntime.InvokeAsync<string>("getBase64");
       fileups.getBase64(text);

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.IFileUpload fileups { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
