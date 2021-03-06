#pragma checksum "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Board.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c474d64aa93d7564f4d667fb9b9479b930cb2b5"
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
#nullable restore
#line 1 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Board.razor"
using Chess.Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Board.razor"
using Chess.Models;

#line default
#line hidden
#nullable disable
    public partial class Board : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "board");
            __builder.AddMarkupContent(2, "\r\n    ");
            __Blazor.Chess.Shared.Board.TypeInference.CreateCascadingValue_0(__builder, 3, 4, 
#nullable restore
#line 7 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Board.razor"
                           this

#line default
#line hidden
#nullable disable
            , 5, (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n");
#nullable restore
#line 8 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Board.razor"
         foreach (var row in board)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(7, "            ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddAttribute(10, "name", 
#nullable restore
#line 10 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Board.razor"
                                    row.Number

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(11, "\r\n                ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "number");
                __builder2.OpenElement(14, "span");
                __builder2.AddContent(15, 
#nullable restore
#line 11 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Board.razor"
                                           row.Number

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n");
#nullable restore
#line 12 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Board.razor"
                 foreach (var field in row.Fields)
                {
                    var position = "" + field.Letter + row.Number;

#line default
#line hidden
#nullable disable
                __builder2.AddContent(17, "                    ");
                __builder2.OpenComponent<Chess.Shared.Field>(18);
                __builder2.AddAttribute(19, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Board.razor"
                                      position

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ColourOfField", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Board.razor"
                                                                field.Colour.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "Piece", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Board.razor"
                                                                                                 field.Piece?.Type.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ColourOfPiece", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Board.razor"
                                                                                                                                               field.Piece?.Colour.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n");
#nullable restore
#line 16 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Board.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(24, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n");
#nullable restore
#line 18 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Board.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(26, "    ");
            }
            );
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "row letterrow");
            __builder.AddMarkupContent(30, "\r\n        <div class=\"doodHoekje\"></div>\r\n");
#nullable restore
#line 22 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Board.razor"
         foreach (var letter in Letters)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "letter");
            __builder.OpenElement(34, "span");
            __builder.AddContent(35, 
#nullable restore
#line 24 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Board.razor"
                                       letter

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 25 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Board.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "feedback");
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.OpenElement(43, "h1");
            __builder.AddContent(44, 
#nullable restore
#line 29 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Board.razor"
         Feedback

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\daanb\Documents\school\CHE\Jaar 2\Testen\Chess\Chess\Chess\Shared\Board.razor"
       
    private List<Row> board;
    private string Feedback { get; set; }
    public string SelectedField { get; private set; }
    public List<string> TargetFields { get; private set; }

    public Colour PlayingNow { get; private set; }

    protected override void OnInitialized()
    {
        ChessService.StartNewGame();
        DrawBoard();
    }

    public void SetSelectedField(string selectedField)
    {
        SelectedField = selectedField;
        if (!string.IsNullOrEmpty(selectedField))
            TargetFields = ChessService.CanMoveTo(selectedField);
        else
            TargetFields = new List<string>(0);
        StateHasChanged();
    }

    public void MovePiece(string targetField)
    {
        var (succes, isChecked) = ChessService.MovePiece(SelectedField, targetField);
        if (succes)
        {
            DrawBoard();
            Feedback = isChecked ? "Check" : "";
            StateHasChanged();
        }
    }

    private void DrawBoard()
    {
        board = ChessService.GetAllFields;
        PlayingNow = ChessService.PlayingNow;
        TargetFields = new List<string>(0);
        SelectedField = "";
    }

    private string Letters => "ABCDEFGH";

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ChessService ChessService { get; set; }
    }
}
namespace __Blazor.Chess.Shared.Board
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
