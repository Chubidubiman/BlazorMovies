using Microsoft.JSInterop;

namespace BlazorMovies.Client.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
        {   
            await js.InvokeVoidAsync("console.log", "Test of console log");
            return await js.InvokeAsync<bool>("confirm", message);
        }
    }
}