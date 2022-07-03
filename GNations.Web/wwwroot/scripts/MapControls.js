function handleMapClick(parameter) {
    console.log(parameter)
    DotNet.invokeMethodAsync('GNations.Web', 'HandleMapClick', parameter);
    console.log("map item clicked");
}

window.getDimensions = function () {
    return {
        width: window.innerWidth,
        height: window.innerHeight
    };
};


$(window).bind("resize", function () {
    // Change the width of the div
    //$("#yourdiv").width(600);
    ResizeMap();
});

function ResizeMap() {
    var viewportSize = getDimensions();
    SetMapHeight(viewportSize.height);
    SetMapWidth(viewportSize.width);
}

function GetMapPosition() {
    var res = $(".map-container").position();
    return {
        top: Math.round(res.top),
        left: Math.round(res.left)
    }
}

function SetMapHeight(currentHeight) {
    var minHeight = 480;
    var setHeigth = Math.round(currentHeight * 0.85);
    if (setHeigth < minHeight) {
        $(".map-container").height(minHeight);
    }
    else {
        $(".map-container").height(Math.round(currentHeight * 0.85));
    }
}

function SetMapWidth(currentWidth) {
    var minWidth = 640;
    if (currentWidth < minWidth) {
        $(".map-container").width(minWidth);
    }
    else {
        $(".map-container").width(currentWidth);
    }
}