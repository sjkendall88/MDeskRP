// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
function getSrc(sentValue) {
    if (sentValue == "pine") {
        document.getElementById("myTopImg").src = "/images/pine.jpg";
    } else if (sentValue == "veneer") {
            document.getElementById("myTopImg").src = "/images/veneer.jpg";
    } else if (sentValue == "laminate") {
        document.getElementById("myTopImg").src = "/images/laminate.jpg";
    } else if (sentValue == "oak") {
        document.getElementById("myTopImg").src = "/images/oak.jpg";
    } else if (sentValue == "rosewood") {
        document.getElementById("myTopImg").src = "/images/rosewood.jpg";
    }

}