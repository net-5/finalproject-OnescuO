function subscribe() {
    $.ajax({
        type: 'POST',
        url: "/MailChimp/Subscribe",
        data: ({ "Email": $('#Email').val() }),
        success: function (resp) {
            $('#Email').hide();
            $('#result').show();
        }
    });
}
