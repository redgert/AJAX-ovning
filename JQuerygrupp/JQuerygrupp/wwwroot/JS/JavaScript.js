$(document).ready(function () {
    $(".customers").on({
        mouseenter: function () {
            console.log("Hej!");
            var customerId = $(this).attr('customerId');
            $(this).css("background-color", "yellow");
            $.ajax({
                url: "/Customers/_CustomerInfo",
                type: "GET",
                data: "id=" + customerId,
                success: function (result) {
                    $("#customerInfoDiv").html(result);
                }
            });
        },
        mouseleave: function () {
            console.log("Hej då!");
            $(this).css("background-color", "white");
            $("#customerInfoDiv").html("");
        }
    });3
});


                //var customerId = 1;
                //var name = $(this).attr('customerName')
                //var city = $(this).attr('customerCity')
                //$("#customerInfoDiv").html("Kundens namn är: " + name + "<br/>" + 
                //    "Staden kunden bor i är: " + city);