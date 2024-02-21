function testDotNetStatic() {
    DotNet.invokeMethodAsync("BlazorMovies.Client","GetCurrentCount")
        .then(result => {
            console.log('Count from javascript ' + result);
        })
}

function testDotNetInstance(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}