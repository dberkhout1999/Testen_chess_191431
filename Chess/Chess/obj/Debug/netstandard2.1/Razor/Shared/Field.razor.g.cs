#pragma checksum "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Field.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38fb97bf8a479cb1e7fc2f64a168a35965ce7059"
// <auto-generated/>
#pragma warning disable 1591
namespace Chess.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\_Imports.razor"
using Chess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\_Imports.razor"
using Chess.Shared;

#line default
#line hidden
#nullable disable
    public partial class Field : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "field" + " Colour_" + (
#nullable restore
#line 1 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Field.razor"
                          ColourOfField

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 1 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Field.razor"
                                          Board.SelectedField==Position?"Selected":""

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 1 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Field.razor"
                                                                                         Board.TargetFields.Contains(Position)?"Target":""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "id", 
#nullable restore
#line 1 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Field.razor"
                                                                                                                                                  Position

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 1 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Field.razor"
                                                                                                                                                                      SelectPiece

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 2 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Field.razor"
     if (Piece != null)
    {
        var imageLocation = $"./{ColourOfPiece}{Piece}.svg";

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "        ");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "src", 
#nullable restore
#line 5 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Field.razor"
                   imageLocation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 6 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Field.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Field.razor"
       
    [Parameter]
    public string Position { get; set; }
    [Parameter]
    public string ColourOfField { get; set; }
    [Parameter]
    public string ColourOfPiece { get; set; }
    [Parameter]
    public string Piece { get; set; }

    [CascadingParameter] Board Board { get; set; }

    private void SelectPiece()
    {
        if (Board.TargetFields.Contains(Position))
        {
            Board.MovePiece(Position);
        }
        else if (Piece != null && ColourOfPiece == Board.PlayingNow.ToString())
        {
            Board.SetSelectedField(Position);
        }
        else
        {// deselect
            Board.SetSelectedField("");
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591