#pragma checksum "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82cd8d9f1445dc4783775b7f9c8bfd03deaaf992"
// <auto-generated/>
#pragma warning disable 1591
namespace TushehbarApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\_Imports.razor"
using TushehbarApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\_Imports.razor"
using TushehbarApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\Pages\FetchData.razor"
using TushehbarApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Phrase Finder</h1>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddAttribute(2, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\Pages\FetchData.razor"
                 FindSentences

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<label for=\"exampleInputEmail1\">Phrase</label>\r\n        ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "placeholder", "Enter phrase");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\Pages\FetchData.razor"
                      phrase

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => phrase = __value, phrase));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.AddMarkupContent(15, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n\r\n");
#nullable restore
#line 17 "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\Pages\FetchData.razor"
 if (sentences == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "    ");
            __builder.AddMarkupContent(18, "<p><em>Please Search a Phrase ...</em></p>\r\n");
#nullable restore
#line 20 "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "    ");
            __builder.OpenElement(20, "table");
            __builder.AddAttribute(21, "class", "table");
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.AddMarkupContent(23, "<thead>\r\n            <tr>\r\n                <th>Sentence</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(24, "tbody");
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 30 "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\Pages\FetchData.razor"
             foreach (var forecast in sentences)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "                ");
            __builder.OpenElement(27, "tr");
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 33 "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\Pages\FetchData.razor"
                         forecast

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 35 "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 38 "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\Pages\FetchData.razor"
       
    private string phrase;
    private List<string> sentences;

    //protected override async Task OnInitializedAsync()
    //{
    //    forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    //}

    private async Task FindSentences()
    {
        sentences = await FinderService.GetSentencesAsync(phrase);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PhraseFinderService FinderService { get; set; }
    }
}
#pragma warning restore 1591
