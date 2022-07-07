'use strict';

function handleMapClick(parameter) {
    console.log(parameter);
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

function ResizeMap(args) {
    console.log(args.width);
    console.log(args.height);
    $(".map-container").width(args.width);
    $(".map-container").height(args.height);
    //SetMapHeight(args.height);
    //SetMapWidth(args.width);
}

function GetMapPosition() {
    var res = $(".map-container").position();
    return {
        top: Math.round(res.top),
        left: Math.round(res.left)
    };
}

function SetMapHeight(currentHeight) {
    var minHeight = 480;
    if (setHeigth < minHeight) {
        $(".map-container").height(minHeight);
    } else {
        $(".map-container").height(currentHeight);
    }
}

function SetMapWidth(currentWidth) {
    var minWidth = 640;
    if (currentWidth < minWidth) {
        $(".map-container").width(minWidth);
    } else {
        $(".map-container").width(currentWidth);
    }
}

$(".editor-container").onmousemove = function (evt) {
    console.log("asdsfd");
    var x = evt.pageX - $(".editor-container").offset().left;
    var y = evt.pageY - $(".editor-container").offset().top;
    console.log(x, y);
};

