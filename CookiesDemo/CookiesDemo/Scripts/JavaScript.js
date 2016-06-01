$(document).ready(function () {
    $('#btnIncrease').on("click", function () {
        var el = document.getElementById('counter');
        var x = el.dataset.value - 0;
        x = x + 1;
        el.dataset.value = x;
        el.innerHTML = x;
    }); //btnIncrease on click


}); // document ready