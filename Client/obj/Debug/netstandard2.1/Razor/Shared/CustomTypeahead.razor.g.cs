#pragma checksum "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\CustomTypeahead.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f33ff1167456710932ca9707ce19a471dda5f64"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\CustomTypeahead.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    public partial class CustomTypeahead<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "blazored-typeahead");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "blazored-typeahead__controls");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "class", "blazored-typeahead__input");
            __builder.AddAttribute(9, "autocomplete", "off");
            __builder.AddAttribute(10, "placeholder", 
#nullable restore
#line 11 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\CustomTypeahead.razor"
                             Placeholder

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\CustomTypeahead.razor"
                          ShowSuggestions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onfocusout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 15 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\CustomTypeahead.razor"
                            onfocusout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\CustomTypeahead.razor"
                             SearchText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchText = __value, SearchText));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 17 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\CustomTypeahead.razor"
     if (IsSearching)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "        ");
            __builder.AddMarkupContent(18, "<div class=\"blazored-typeahead__results\">\r\n            <div class=\"blazored-typeahead__results\">\r\n                <span>Loading...</span>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 24 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\CustomTypeahead.razor"
    }
    else if (ShouldShowSuggestions())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "blazored-typeahead__results");
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 28 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\CustomTypeahead.razor"
             foreach (var item in Suggesions)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "blazored-typeahead__results");
            __builder.AddAttribute(26, "tabindex", "0");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\CustomTypeahead.razor"
                                              () => SelectSuggestions(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\CustomTypeahead.razor"
                                   OnmouseoverSuggestion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\CustomTypeahead.razor"
                                                                       OnmouseoutSuggestion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.AddContent(31, 
#nullable restore
#line 34 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\CustomTypeahead.razor"
                     ResultTemplate(item)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 36 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\CustomTypeahead.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 38 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\CustomTypeahead.razor"
    }
    else if (ShowNotFound())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "blazored-typeahead__results");
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 42 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\CustomTypeahead.razor"
             if (NotFoundTemplate != null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "                ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "blazored-typeahead__notfound");
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.AddContent(44, 
#nullable restore
#line 45 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\CustomTypeahead.razor"
                     NotFoundTemplate

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 47 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\CustomTypeahead.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "                ");
            __builder.AddMarkupContent(48, "<div class=\"blazored-typeahead__notfound\">\r\n                    No Results Found\r\n                </div>\r\n");
#nullable restore
#line 53 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\CustomTypeahead.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 55 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\CustomTypeahead.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\CustomTypeahead.razor"
       
    [Parameter] public string Placeholder { get; set; }
    [Parameter] public int MinimumLength { get; set; } = 3;
    [Parameter] public int Debounce { get; set; } = 300;
    [Parameter] public Func<string, Task<IEnumerable<TItem>>> SearchMethod { get; set; }
    [Parameter] public RenderFragment<TItem> ResultTemplate { get; set; }
    [Parameter] public RenderFragment NotFoundTemplate { get; set; }
    [Parameter] public EventCallback<TItem> ValueChanged { get; set; }

    private bool IsSearching = false;
    private bool IsShowingSuggestions = false;
    private string _searchText = string.Empty;
    private Timer _debounceTimer;
    protected TItem[] Suggesions { get; set; } = new TItem[0];

    protected override void OnInitialized()
    {
        _debounceTimer = new Timer();
        _debounceTimer.Interval = Debounce;
        _debounceTimer.AutoReset = false;
        _debounceTimer.Elapsed += Search;
        base.OnInitialized();
    }

    private bool ShowNotFound()
    {
        return !Suggesions.Any() && IsShowingSuggestions;
    }

    private async Task SelectSuggestions(TItem item)
    {
        SearchText = "";
        await ValueChanged.InvokeAsync(item);
    }

    protected async void Search(Object source, ElapsedEventArgs e)
    {
        IsSearching = true;
        IsShowingSuggestions = false;
        await InvokeAsync(StateHasChanged);

        Suggesions = (await SearchMethod.Invoke(_searchText)).ToArray();

        IsSearching = false;
        IsShowingSuggestions = true;
        await InvokeAsync(StateHasChanged);
    }

    private string SearchText
    {
        get => _searchText;
        set
        {
            _searchText = value;

            if (value.Length == 0)
            {
                IsShowingSuggestions = false;
                _debounceTimer.Stop();
                Suggesions = new TItem[0];
            }
            else if (value.Length >= MinimumLength)
            {
                _debounceTimer.Stop();
                _debounceTimer.Start();
            }
        }
    }

    private bool ShouldShowSuggestions()
    {
        return IsShowingSuggestions && Suggesions.Any();
    }

    private void ShowSuggestions()
    {
        if (Suggesions.Any())
        {
            IsShowingSuggestions = true;
        }
    }

    private void onfocusout()
    {
        if (!IsMouseInSuggestion)
        {
            IsShowingSuggestions = true;
        }
    }

    bool IsMouseInSuggestion = false;

    private void OnmouseoverSuggestion()
    {
        IsMouseInSuggestion = true;
    }

    private void OnmouseoutSuggestion()
    {
        IsMouseInSuggestion = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
