$(document).ready(function(){
    $("#room1").css("background-color", getCookie("room.1.color"));
    $("#room2").css("background-color", getCookie("room.2.color"));
    $("#room3").css("background-color", getCookie("room.3.color"));
    $("#room4").css("background-color", getCookie("room.4.color"));
    $("#room5").css("background-color", getCookie("room.5.color"));
    $("#room6").css("background-color", getCookie("room.6.color"));
    $("#room7").css("background-color", getCookie("room.7.color"));
    $("#room8").css("background-color", getCookie("room.8.color"));
    $("#room9").css("background-color", getCookie("room.9.color"));
    $("#room10").css("background-color", getCookie("room.10.color"));

});

$('#add').click(function(){
    $('.form_container').show();
    $('.form_container').load('checkin_form.php');
    $('#room_info').hide();
    
});


function getCookie(name) {
    var cookieArr = document.cookie.split(";");
    for(var i = 0; i < cookieArr.length; i++) {
        var cookiePair = cookieArr[i].split("=");
        if(name == cookiePair[0].trim()) {
            return decodeURIComponent(cookiePair[1]);
        }
    }
    return null;
}


function show()
{
    if(getCookie("zalogowany_recepcjonista") == 1)
    {
    $('#room_info').show();
    $('#room_info').load('room_info_get.php');
    $('.form_container').toggle();
    }
    else if(getCookie("zalogowany_cleaner") == 1)
    {
    $('#cleaner_form').show();
    $('#cleaner_form').load('cleaner_panel.php');
    }
}

$('#room1').click(function(){
    document.cookie="current_room=1";
    show();
})

$('#room2').click(function(){
    document.cookie="current_room=2";

    show();
})

$('#room3').click(function(){
    document.cookie="current_room=3";

    show();
})

$('#room4').click(function(){
    document.cookie="current_room=4";

    show();
})

$('#room5').click(function(){
    document.cookie="current_room=5";

    show();
})

$('#room6').click(function(){
    document.cookie="current_room=6";

    show();
})

$('#room7').click(function(){
    document.cookie="current_room=7";

    show();
})

$('#room8').click(function(){
    document.cookie="current_room=8";

    show();
})

$('#room9').click(function(){
    document.cookie="current_room=9";

    show();
})

$('#room10').click(function(){
    document.cookie="current_room=10";

    show();
})