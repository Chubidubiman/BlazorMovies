using BlazorMovies.Client.Helpers;
using BlazorMovies.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorMovies.Client.Pages
{
    public partial class Counter
    {
        [Inject] ServicesSingleton singleton { get; set; } = null!;
        [Inject] ServicesTransient transient { get; set; } = null!;
        [Inject] IJSRuntime js { get; set; } = null!;
        //[CascadingParameter(Name = "Color")] protected string Color { get; set; } = null!;
        //[CascadingParameter(Name = "Size")] protected string Size { get; set; } = null!;
        [CascadingParameter] protected AppState appState { get; set; } = null!;
        IJSObjectReference? module;
        private int currentCount = 0;
        private static int currentCountStatic = 0;
        [JSInvokable]
        public async Task IncrementCount()
        {
            module = await js.InvokeAsync<IJSObjectReference>("import", "./js/Counter.js");
            await module.InvokeVoidAsync("ShowAlert", "Hello World!");

            currentCount++;
            currentCountStatic = currentCount;
            singleton.Val = currentCount;
            transient.Val = currentCount;
            await js.InvokeVoidAsync("testDotNetStatic");
        }

        private async Task IncrementCountJavaScript()
        {
            await js.InvokeVoidAsync("testDotNetInstance",
                DotNetObjectReference.Create(this));
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}