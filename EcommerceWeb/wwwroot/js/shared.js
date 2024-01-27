$(document).ready(function () {
    $('#headerSearchInput').on('input', function () {
        var searchTerm = $(this).val().toLowerCase();
        $('.product-card').each(function () {
            var productTitle = $(this).find('.card-title').text().toLowerCase();
            $(this).toggle(productTitle.includes(searchTerm));
        });
    });
});
