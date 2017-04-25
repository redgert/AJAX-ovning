$(document).ready(function () {

    $("#GetAll").click(function () {
        $.getJSON({
            url: "/Customers/GetAll",
            success: function (result) {
                console.log(result);
                $("#allCustomers").html(result.length);
            }
        });
    });
});