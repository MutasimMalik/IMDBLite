#pragma checksum "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\MultipleSelector.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c291d4f66efbb8b4dcf248cb070221cf4302aea3"
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
    public partial class MultipleSelector : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\MultipleSelector.razor"
       
    private string removeAllText = "<<";
    [Parameter]
    public List<MultipleSelectorModel> NoSelected { get; set; }
    = new List<MultipleSelectorModel>();
    [Parameter]
    public List<MultipleSelectorModel> Selected { get; set; }
    = new List<MultipleSelectorModel>();

    private void Select(MultipleSelectorModel item)
    {
        NoSelected.Remove(item);
        Selected.Add(item);
    }

    private void Deselect(MultipleSelectorModel item)
    {
        Selected.Remove(item);
        NoSelected.Add(item);
    }

    private void SelectAll()
    {
        Selected.AddRange(NoSelected);
        NoSelected.Clear();
    }

    private void DeselectAll()
    {
        NoSelected.AddRange(Selected);
        Selected.Clear();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
