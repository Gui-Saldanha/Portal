function ConfirmedPassword() {
    var listPassword = $('input[type="password"]').each();

    if (listPassword === undefined || listPassword.length === 0)
        return true;

    var bRetorno = listPassword[0] === listPassword[1];

    if (!bRetorno)
        if (listPassword[1].parent().hasClass('label-input'))
            listPassword[1].parent().after('<span class="text-danger">As senhas não conferem</span>');
        else
            listPassword[1].after('<span class="text-danger">As senhas não conferem</span>');

    return bRetorno;
}