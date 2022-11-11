function AddClass() {
    if ($(document).find('.validation').length === 0) {
        $('input').addClass('validation');
        $('select').addClass('validation');
        $('textarea').addClass('validation');
    }
}

function Validation() {
    var totalValidar = $(document).find('.validation').length;
    var totalValidado = 0;

    $('span[class="text-danger"]').remove();
    $('.validation').removeClass('border-danger');
    
    $('.validation').each(function () {
        var element = $(this);

        if (element.val() === undefined || element.val() === '') {
            element.addClass('border-danger');

            if (element.parent().hasClass('label-input'))
                element.parent().after('<span class="text-danger">Este campo é obrigatório</span>');
            else
                element.after('<span class="text-danger">Este campo é obrigatório</span>');
        }
        else
            totalValidado++;
    });

    $('span[class="text-danger"]').css('margin-left', '8px');

    if ((totalValidar === totalValidado && ConfirmedPassword()) || ($('.form').length === 2 && totalValidar === 5 && (((($('body').hasClass('sign-up-js') && totalValidado === 3) || (($('body').find('sign-up-js').length === 0 && $('body').find('sign-in-js').length === 0) && totalValidado === 3)) || ($('body').hasClass('sign-in-js') && totalValidado === 2)))))
        return true;
    else
        return false;
}

$(document).ready(function () {
    AddClass();
});

$('button[type="submit"]').click(function () {
    return Validation();
});

$('#signup').click(function () {
    $('span[class="text-danger"]').remove();
    $('.validation').removeClass('border-danger');
    Clean();
});

$('#signin').click(function () {
    $('span[class="text-danger"]').remove();
    $('.validation').removeClass('border-danger');
    Clean();
});