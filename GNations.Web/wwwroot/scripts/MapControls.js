function handleMapClick(parameter) {
    console.log(parameter)
    DotNet.invokeMethodAsync('GNations.Web', 'HandleMapClick', parameter);
    console.log("map item clicked");
}