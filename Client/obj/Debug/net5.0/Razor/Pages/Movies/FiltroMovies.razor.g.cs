#pragma checksum "C:\Sprint3\Client\Pages\Movies\FiltroMovies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be50a516621c96d818782d139eda1354a227607e"
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
#line 2 "C:\Sprint3\Client\Pages\Movies\FiltroMovies.razor"
using Sprint3.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/search")]
    public partial class FiltroMovies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.AddMarkupContent(2, "<h3 class=\"display-4.5\">Buscar pelicula</h3>\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-inline");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-group mb-2");
            __builder.AddMarkupContent(7, "<label for=\"moviename\" class=\"sr-only\"> Nombre Pelicula</label>\n        ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 10 "C:\Sprint3\Client\Pages\Movies\FiltroMovies.razor"
                       (KeyboardEventArgs e) =>MovieNameKeyPress(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "id", "movie_name");
            __builder.AddAttribute(13, "Placeholder", "Buscar pelicula");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Sprint3\Client\Pages\Movies\FiltroMovies.razor"
                                         movie_name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => movie_name = __value, movie_name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "form-group mx-sm-3 mb-2");
            __builder.OpenElement(19, "select");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Sprint3\Client\Pages\Movies\FiltroMovies.razor"
                                            categorySelectd

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => categorySelectd = __value, categorySelectd));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value", "0");
            __builder.AddContent(25, "Seleccione un Genero");
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Sprint3\Client\Pages\Movies\FiltroMovies.razor"
             foreach (var item in genres)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "option");
            __builder.AddAttribute(27, "value", 
#nullable restore
#line 19 "C:\Sprint3\Client\Pages\Movies\FiltroMovies.razor"
                                item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(28, 
#nullable restore
#line 19 "C:\Sprint3\Client\Pages\Movies\FiltroMovies.razor"
                                          item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Sprint3\Client\Pages\Movies\FiltroMovies.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", " form-inline");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group mx-sm-3 mb-2");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "type", "checkbox");
            __builder.AddAttribute(36, "class", "form-check-input");
            __builder.AddAttribute(37, "id", "estrenos");
            __builder.AddAttribute(38, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Sprint3\Client\Pages\Movies\FiltroMovies.razor"
                                                                             futurosEstrenos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => futurosEstrenos = __value, futurosEstrenos));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n        ");
            __builder.AddMarkupContent(41, "<label class=\"form-check-label\" for=\"estrenos\">Futuros estrenos</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n\n    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "form-group mx-sm-3 mb-2");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "checkbox");
            __builder.AddAttribute(47, "class", "form-check-input");
            __builder.AddAttribute(48, "id", "cartelera");
            __builder.AddAttribute(49, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Sprint3\Client\Pages\Movies\FiltroMovies.razor"
                                                                              enCartelera

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => enCartelera = __value, enCartelera));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n        ");
            __builder.AddMarkupContent(52, "<label class=\"form-check-label\" for=\"cartelera\">En cartelera</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n\n    ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "form-group mx-sm-3 mb-2");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "type", "checkbox");
            __builder.AddAttribute(58, "class", "form-check-input");
            __builder.AddAttribute(59, "id", "mejor_Calificadas");
            __builder.AddAttribute(60, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Sprint3\Client\Pages\Movies\FiltroMovies.razor"
                                                                                      mejorCalificadas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => mejorCalificadas = __value, mejorCalificadas));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n        ");
            __builder.AddMarkupContent(63, "<label class=\"form-check-label\" for=\"mejor_Calificadas\">Mejor calificadas</label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\n");
            __builder.OpenElement(65, "button");
            __builder.AddAttribute(66, "type", "button");
            __builder.AddAttribute(67, "class", "btn btn-primary mb-2 btn-sm");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Sprint3\Client\Pages\Movies\FiltroMovies.razor"
                                                                    CargarNuevasMovies

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(69, "\n        Buscar\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\n    ");
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "type", "button");
            __builder.AddAttribute(73, "class", "btn btn-danger mb-2 btn-sm");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Sprint3\Client\Pages\Movies\FiltroMovies.razor"
                                                                       LimpiarCampos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(75, "\n        Limpiar campos\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\n\n");
            __builder.OpenComponent<Sprint3.Client.Pages.Components.CardMovieComponent>(77);
            __builder.AddAttribute(78, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Sprint3.Shared.Entity.Movie>>(
#nullable restore
#line 48 "C:\Sprint3\Client\Pages\Movies\FiltroMovies.razor"
                            Movies

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Sprint3\Client\Pages\Movies\FiltroMovies.razor"
      
    private List<Movie> Movies;
    string movie_name="";
    string categorySelectd ="";
    private bool futurosEstrenos =false;
    private bool enCartelera =false;
    private bool mejorCalificadas =false;

    protected override void OnInitialized()
        {
            Movies = movie.GetMovies();
        }


    private List<Genre> genres =new List<Genre>();
    private void MovieNameKeyPress(KeyboardEventArgs e){
        if(e.Key =="Enter");
        {
            CargarNuevasMovies();
        }
    }
    private void CargarNuevasMovies(){
        Movies =movie.GetMovies().Where(x=>x.MovieName.ToLower().Contains(movie_name.ToLower())).ToList();
        Console.WriteLine($"Nombre pelicula: {movie_name}");
        Console.WriteLine($"Genero seleccionado: {categorySelectd}");
        Console.WriteLine($"Futuros estrenos: {futurosEstrenos}");
        Console.WriteLine($"En cartelera: {enCartelera}");
        Console.WriteLine($"Mejor calificadas: {mejorCalificadas}");
    }

    private void LimpiarCampos(){
        Movies = movie.GetMovies();
        movie_name ="";
        categorySelectd="0";
        futurosEstrenos =false;
        enCartelera =false;
        mejorCalificadas =false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie movie { get; set; }
    }
}
#pragma warning restore 1591
