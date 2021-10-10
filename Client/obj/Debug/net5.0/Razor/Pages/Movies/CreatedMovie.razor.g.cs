#pragma checksum "C:\Sprint3\Client\Pages\Movies\CreatedMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f6a51ac10efc2f475fdd994eabf1c51344d952d"
// <auto-generated/>
#pragma warning disable 1591
namespace Sprint3.Client.Pages.Movies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Sprint3\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Sprint3\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Sprint3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Sprint3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Sprint3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Sprint3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Sprint3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Sprint3\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Sprint3\Client\_Imports.razor"
using Sprint3.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Sprint3\Client\_Imports.razor"
using Sprint3.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Sprint3\Client\_Imports.razor"
using Sprint3.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Sprint3\Client\_Imports.razor"
using Sprint3.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Sprint3\Client\Pages\Movies\CreatedMovie.razor"
using Sprint3.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/create")]
    public partial class CreatedMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h6 class=\"display-4\">Crear peliculas</h6>\n");
            __builder.OpenComponent<Sprint3.Client.Pages.Movies.FormMovie>(1);
            __builder.AddAttribute(2, "Movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Sprint3.Shared.Entity.Movie>(
#nullable restore
#line 6 "C:\Sprint3\Client\Pages\Movies\CreatedMovie.razor"
                  Movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 6 "C:\Sprint3\Client\Pages\Movies\CreatedMovie.razor"
                                        Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "CategoriasNoSeleccionadas", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Sprint3.Shared.Entity.Genre>>(
#nullable restore
#line 6 "C:\Sprint3\Client\Pages\Movies\CreatedMovie.razor"
                                                                           CategoriasNoSeleccionadas

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Sprint3\Client\Pages\Movies\CreatedMovie.razor"
       
    private Movie Movie = new Movie();
    private List<Genre> CategoriasNoSeleccionadas = new List<Genre>();

    protected override void OnInitialized()
    {
        CategoriasNoSeleccionadas = new List<Genre>(){
new Genre(){Id = 1, Name="Comedia"},
new Genre(){Id = 2, Name="Terror"},
new Genre(){Id = 3, Name="Ciencia Ficción"},
new Genre(){Id = 4, Name="Documentales"},
new Genre(){Id = 5, Name="Comedia"}
};
    }
    void Create()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Sprint3\Client\Pages\Movies\CreatedMovie.razor"
                                                                                                        
        Console.WriteLine(navigationManager.Uri);
        navigationManager.NavigateTo("movie");
        Console.WriteLine($"Pelicula: {Movie.MovieName}");
        Console.WriteLine($"Premier: {Movie.MovieReleaseDate}");
        Console.WriteLine($"Esta en cartelera: {Movie.Raiting}");
        Console.WriteLine($"Poster: {Movie.Image}");
        Console.WriteLine($"Sinopsis: {Movie.Synopsis}");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
