#pragma checksum "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\MoviesList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2dc1323cd8d5c5f6749ff517f0a26ec1a761e22"
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
    public partial class MoviesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "movies-container");
            __builder.AddMarkupContent(2, "\r\n        ");
            __Blazor.IMDBlite.Client.Shared.MoviesList.TypeInference.CreateGenericList_0(__builder, 3, 4, 
#nullable restore
#line 4 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\MoviesList.razor"
                                    Movies

#line default
#line hidden
#nullable disable
            , 5, (movie) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n                ");
                __builder2.OpenComponent<IMDBlite.Client.Shared.IndividualMovie>(7);
                __builder2.AddAttribute(8, "Movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<IMDBlite.Shared.Entities.Movie>(
#nullable restore
#line 6 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\MoviesList.razor"
                                        movie

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "DeleteMovieEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<IMDBlite.Shared.Entities.Movie>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<IMDBlite.Shared.Entities.Movie>(this, 
#nullable restore
#line 6 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\MoviesList.razor"
                                                                 DeleteMovieFunc

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n            ");
            }
            );
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\D Drive Backup (Malik Apsis)\Blazor\IMDBlite\Client\Shared\MoviesList.razor"
       
    [Parameter] public List<Movie> Movies { get; set; }

    public async Task DeleteMovieFunc(Movie movie)
    {
        await js.MyFunction("Custom Message");

        var confirmed = await js.Confirm($"Are you sure you want to Delete {movie.Title}");

        if (confirmed)
        {
            Movies.Remove(movie);
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
namespace __Blazor.IMDBlite.Client.Shared.MoviesList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1)
        {
        __builder.OpenComponent<global::IMDBlite.Client.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "ListGenerenic", __arg0);
        __builder.AddAttribute(__seq1, "ItemTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
