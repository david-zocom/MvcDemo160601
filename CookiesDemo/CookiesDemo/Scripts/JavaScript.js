$(document).ready(function () {
    $('#btnIncrease').on("click", function () {
        var el = document.getElementById('counter');
        var x = el.dataset.david - 0;
        x = x + 1;
        el.dataset.david = x;
        el.innerHTML = x;
    }); //btnIncrease on click

    $('#btnDecrease').on('click', function () {
        var el = $('#counter');
        var x = el.data('david') - 0;
        x = x - 1;
        el.data('david', x);
        el.html(x);
    });
}); // document ready