#pragma checksum "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\MultipleSelectTypeahead.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4167bb1cb228addfd7ac7620b2de88f89620576a"
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
    public partial class MultipleSelectTypeahead<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.IMDBlite.Client.Shared.MultipleSelectTypeahead.TypeInference.CreateCustomTypeahead_0(__builder, 0, 1, 
#nullable restore
#line 3 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\MultipleSelectTypeahead.razor"
                                 (string searchText) => SearchMethod(searchText)

#line default
#line hidden
#nullable disable
            , 2, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 4 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\MultipleSelectTypeahead.razor"
                                 (T item) => SelectedElement(item)

#line default
#line hidden
#nullable disable
            ), 3, (context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.AddContent(5, 
#nullable restore
#line 7 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\MultipleSelectTypeahead.razor"
         MyResultTemplate(context)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(6, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "ul");
            __builder.AddAttribute(9, "class", "list-group");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 12 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\MultipleSelectTypeahead.razor"
     foreach (var item in SelectedElements)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "        ");
            __builder.OpenElement(12, "li");
            __builder.AddAttribute(13, "draggable", "true");
            __builder.AddAttribute(14, "ondragstart", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 15 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\MultipleSelectTypeahead.razor"
                            ()=>HandleDragStart(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ondragover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 16 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\MultipleSelectTypeahead.razor"
                           ()=>HandleDragOver(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "class", "list-group-item list-group-item-action");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.AddContent(18, 
#nullable restore
#line 18 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\MultipleSelectTypeahead.razor"
             MylistTemplate(item)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "span");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\MultipleSelectTypeahead.razor"
                              ()=>SelectedElements.Remove(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "X");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 21 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\MultipleSelectTypeahead.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\MultipleSelectTypeahead.razor"
       
    [Parameter] public List<T> SelectedElements { get; set; } = new List<T>();
    [Parameter] public Func<string, Task<IEnumerable<T>>> SearchMethod { get; set; }
    [Parameter] public RenderFragment<T> MyResultTemplate { get; set; }
    [Parameter] public RenderFragment<T> MylistTemplate { get; set; }

    T draggedItem;

    private void SelectedElement(T item)
    {
        if(!SelectedElements.Any(x=>x.Equals(item)))
        {
            SelectedElements.Add(item);
        }
    }

    private void HandleDragStart(T item)
    {
        draggedItem = item;
    }

    private void HandleDragOver(T item)
    {
        if(!item.Equals(draggedItem))
        {
            var draggedElementIndex = SelectedElements.IndexOf(draggedItem);
            var elementIndex = SelectedElements.IndexOf(item);
            SelectedElements[elementIndex] = draggedItem;
            SelectedElements[draggedElementIndex] = item;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.IMDBlite.Client.Shared.MultipleSelectTypeahead
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCustomTypeahead_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<TItem>>> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TItem> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg2)
        {
        __builder.OpenComponent<global::IMDBlite.Client.Shared.CustomTypeahead<TItem>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ResultTemplate", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591