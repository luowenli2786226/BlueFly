$(function () {
    var id = getQueryString("id");

    $(".box_others_li").each(function ()
    {
        if ($(this).attr("id") == "li" + id) {
            $("#li" + id).css("background", "url(/Style/images/first-bg-003.jpg)");

        }
        else {
            $(this).hover(function () {
                $(this).css("background", "url(/Style/images/first-bg-002.jpg)");
            }, function () { $(this).css("background", "url(/Style/images/first-bg-001.jpg)"); })
        }
    })
   
    if (id == 3)
    {
        $("#photomsg").show();
    }
    if (id == 2)
    {
        $("#photoenvioronment").show();
    }
    
	  
})

function getQueryString(name) {
    var reg = new RegExp('(^|&)' + name + '=([^&]*)(&|$)', 'i');
    var r = window.location.search.substr(1).match(reg);
    if (r != null) {
        return unescape(r[2]);
    }
    return null;
}