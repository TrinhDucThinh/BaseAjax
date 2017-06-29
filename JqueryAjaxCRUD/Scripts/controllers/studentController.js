var studentController = {
    init: function () {
        studentController.loadData();
        studentController.registerEvent();
    },
    loadData: function () {
        $.ajax({
            url: "/Student/LoadData",
            type: "GET",
            dataType: "json",
            success: function (response) {
                var data = response.data;
                var html = "";
                var template = $('#data-template').html();
                $.each(data, function (i, item) {
                    html += Mustache.render(template, {
                        Index: i + 1,
                        Name: item.Name,
                        DateOfBirth: moment(Number(item.DateOfBirth.match(/\d+/)[0])).format('DD/MM/YYYY'),
                        Email: item.Email,
                        Status:item.Status
                    })
                })
                $('#tblStudent').html(html);
                studentController.registerEvent();
            }
        });
    },
    registerEvent: function () {

    }

};

studentController.init();