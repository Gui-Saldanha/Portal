$('#signin').click(function () {
    $('body').addClass('sign-in-js');
    $('body').removeClass('sign-up-js');
});

$('#signup').click(function () {
    $('body').addClass('sign-up-js');
    $('body').removeClass('sign-in-js');
});