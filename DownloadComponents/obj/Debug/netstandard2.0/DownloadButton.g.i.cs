#pragma checksum "C:\Users\edcha\source\repos\BlazeDown\DownloadComponents\DownloadButton.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01832581d483f6c6ee1d3030e62b1d16d2bb70d9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DownloadComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    public class DownloadButton : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 5 "C:\Users\edcha\source\repos\BlazeDown\DownloadComponents\DownloadButton.cshtml"
            

    private void OnClicked(UIMouseEventArgs e)
    {
        MsSaveBlobInterop.MsSaveBlob(Payload, FileName);
    }

    // Content output between <a> child content </a>
    [Parameter] RenderFragment ChildContent { get; set; }

    // Component Properties

    /// <summary>
    /// Gets or Sets the data to be downloaded by the client.
    /// </summary>
    [Parameter] string Payload { get; set; }

    /// <summary>
    /// Gets or Sets the specified file name.
    /// </summary>
    [Parameter] string FileName { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
