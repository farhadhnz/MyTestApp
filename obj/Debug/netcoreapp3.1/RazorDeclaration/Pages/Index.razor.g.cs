#pragma checksum "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b822bb505c1e2c7b6a70ba7e0ef490f8104c106b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\Pages\Index.razor"
using TushehbarApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\Farhad\source\repos\asdasd\TushehbarApp\TushehbarApp\Pages\Index.razor"
       
    private string phrase;
    private List<string> sentences;

    //protected override async Task OnInitializedAsync()
    //{
    //    forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    //}

    private async Task FindSentences()
    {
        if (phrase != null || string.IsNullOrEmpty(phrase) || string.IsNullOrWhiteSpace(phrase))
        {
            return;
        }
        sentences = await FinderService.GetSentencesAsync(phrase);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PhraseFinderService FinderService { get; set; }
    }
}
#pragma warning restore 1591