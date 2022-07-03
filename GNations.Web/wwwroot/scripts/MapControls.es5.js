'use strict';

function handleMapClick() {
    DotNet.invokeMethodAsync('GNations.Web', 'HandleMapClick');
    console.log("map item clicked");
}

