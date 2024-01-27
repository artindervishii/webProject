var dataTable;

$(document).ready(function () {
    var url = window.location.search;
    var defaultStatus;

    if (url.includes("inprocess")) {
        defaultStatus = "inprocess";
    } else if (url.includes("completed")) {
        defaultStatus = "completed";
    } else if (url.includes("pending")) {
        defaultStatus = "pending";
    } else if (url.includes("approved")) {
        defaultStatus = "approved";
    } else {
        defaultStatus = "all";
    }

    
    if ($.fn.DataTable.isDataTable('#tblData')) {
        
        $('#tblData').DataTable().destroy();
    }

    loadDataTable(defaultStatus);
});

function loadDataTable(status) {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/order/getall?status=' + status },
        "columns": [
            { data: 'id', "width": "5%" },
            { data: 'name', "width": "25%" },
            { data: 'phoneNumber', "width": "20%" },
            { data: 'applicationUser.email', "width": "20%" },
            { data: 'orderStatus', "width": "10%" },
            { data: 'orderTotal', "width": "10%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                        <a href="/admin/order/details?orderId=${data}" class="btn btn-primary mx-2 bg-info">
                            <i class="bi bi-pencil-square"></i>
                        </a>
                    </div>`;
                },
                "width": "10%"
            }
        ]
    });
}
