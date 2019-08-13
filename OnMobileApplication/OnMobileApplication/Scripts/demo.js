function showDetail(x) {
    $("#detailShowId").empty();
    $.ajax({
        type: 'GET',
        url: 'http://localhost:63841/api/OnMobileServiceAPI',
        data: {gallaryNamePara:x},
        dataType: 'JSON'
    }).success(function (data) {
        if (data != null)
        {
            var y = undefined;
            y = "<table class='table' border='1'><thead><tr><th>GallaryName</th><th>BookName</th><th>AuthorName</th><th>GallaryDescription</th></thead><tbody>";
            $.each(data, function (ind, val) {
                y = y + "<tr><td>" + val["GallaryName"] + "</td><td>" + val["BookName"] + "</td><td>" + val["AuthorName"] + "</td><td>" + val["GallaryDescription"] + "</td></tr>";
            });
            y = y + "</tbody></table>";
            $("#detailShowId").append(y);
            $("#detailShowId").show();
        }
        else {
            $("#detailShowId").html("<h3 style='color:red'>Sorry, No data available and associated with Gallary Name: "+x+"<h3>"); // Put the message content inside div  
        }
    }).error(function (err) {
        console.log("Got Error");
    });
}