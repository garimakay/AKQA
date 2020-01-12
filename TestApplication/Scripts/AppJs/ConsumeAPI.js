function HitAPI() {
    debugger;
    if ($('#EMPName').val() === "" || $('#EMPName').val() === undefined || $('#EMPName').val() === null) {
        alert("Please Enter Name");
        return false;
    }
    if ($('#EMPNo').val() === "" || $('#EMPNo').val() === undefined || $('#EMPNo').val() === null) {
        alert("Please Enter Number");
        return false;
    }
    $.ajax({
        type: 'GET',
        url: 'https://localhost:44340/home?Data=' + $('#EMPNo').val(),
        dataType: 'json',
        success: function (data) {
            if (data.MessageId === 1) {
                $('#RecData').html($('#EMPName').val().toUpperCase() + "<br />" + data.Data);
            }
            else {
                alert("Error Occured");
            }
            
        }

    });
}