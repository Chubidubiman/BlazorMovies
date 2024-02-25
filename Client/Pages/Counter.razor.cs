using MathNet.Numerics.Statistics;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorMovies.Client.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
        [Inject] public IJSRuntime js { get; set; } = null!;
        public async Task IncrementCount()
        {
            var array = new double[] { 1, 2, 3, 4, 5 };
            var max = array.Maximum();
            var min = array.Minimum();

            await js.InvokeVoidAsync($"alert",$"The max {max} is and tne min is {min}");

            currentCount++;
        }
    }
}