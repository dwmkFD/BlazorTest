#pragma checksum "D:\My Documents\text\git_workspace\BlazorTest\Client\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4843fdc24c05f03477dfa09c196aaa42d52ff054"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTest.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\My Documents\text\git_workspace\BlazorTest\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\My Documents\text\git_workspace\BlazorTest\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\My Documents\text\git_workspace\BlazorTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\My Documents\text\git_workspace\BlazorTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\My Documents\text\git_workspace\BlazorTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\My Documents\text\git_workspace\BlazorTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\My Documents\text\git_workspace\BlazorTest\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\My Documents\text\git_workspace\BlazorTest\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\My Documents\text\git_workspace\BlazorTest\Client\_Imports.razor"
using BlazorTest.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\My Documents\text\git_workspace\BlazorTest\Client\_Imports.razor"
using BlazorTest.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "D:\My Documents\text\git_workspace\BlazorTest\Client\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "D:\My Documents\text\git_workspace\BlazorTest\Client\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-primary");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\My Documents\text\git_workspace\BlazorTest\Client\Pages\Counter.razor"
                                          IncrementCount2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Click me2");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "D:\My Documents\text\git_workspace\BlazorTest\Client\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

    private int currentCount2 = 0;
    private void IncrementCount2()
    {
        currentCount2++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591