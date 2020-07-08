#pragma checksum "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\InputImg.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b664d4721d452fb6b549fd902cb4d7a596be47f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace IMDBlite.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\_Imports.razor"
using IMDBlite.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\_Imports.razor"
using IMDBlite.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\_Imports.razor"
using IMDBlite.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\_Imports.razor"
using IMDBlite.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\InputImg.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\InputImg.razor"
using Blazor.FileReader;

#line default
#line hidden
#nullable disable
    public partial class InputImg : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\InputImg.razor"
       
    [Parameter] public string Label { get; set; } = "Image";
    [Parameter] public string ImageURL { get; set; }
    [Parameter] public EventCallback<string> OnSelectedImage { get; set; }
    private string imageBase64;
    ElementReference inputElement;

    async Task ImageFileSelected()
    {
        foreach(var file in await fileReaderService.CreateReference(inputElement).EnumerateFilesAsync())
        {
            using (MemoryStream memoryStream = await file.CreateMemoryStreamAsync(4*1024))
            {
                var imageBytes = new byte[memoryStream.Length];
                memoryStream.Read(imageBytes, 0, (int)memoryStream.Length);
                imageBase64 = Convert.ToBase64String(imageBytes);
                await OnSelectedImage.InvokeAsync(imageBase64);
                ImageURL = null;
                StateHasChanged();
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazor.FileReader.IFileReaderService fileReaderService { get; set; }
    }
}
#pragma warning restore 1591
