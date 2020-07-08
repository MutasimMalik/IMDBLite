function my_function(message) {
    console.log("from utilities" + message);
}

function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("IMDBlite.Client", "GetCurrentCount")
        .then(result => {
            console.log("count from javascript " + result);
        });
}

function dotnetInstanceInvokation(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}