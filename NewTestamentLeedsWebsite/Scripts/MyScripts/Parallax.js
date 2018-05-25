function parallax() {
    var scrolled = $(window).scrollTop();
    $('.homeBackground').css('top', 1400 -(scrolled * 0.4) + 'px');
}

$(window).scroll(function () {
    parallax();
});

$(document).ready(function () {
    $("#loginForm").dialog({
        autoOpen: false,
        modal:true,
        width: 1000,
        buttons: [
            {
                text: "Ok",
                click: function () {
                    $(this).dialog("close");
                }
            },
            {
                text: "Cancel",
                click: function () {
                    $(this).dialog("close");
                }
            }
        ]
    });
});

$('.ntcglogo').dblclick(function () {

    $("#loginForm").dialog("open");
    $.ajax({
        url: "/Account/Login?returnUrl=''",
        type: 'Get',
        dataType: 'html',
        success: function (data) {
            $("#loginForm").dialog("open");
            $("#loginForm").empty().append(data);
            $("#loginForm").dialog('option', 'title', 'Logging In!!!!');
        },
        error: function (errorData) {
            alert("something seems wrongwith the login double click");
        }
    });
});
