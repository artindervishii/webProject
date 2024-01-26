﻿

var dataTable;


$(document).ready(function () {

    if ($.fn.DataTable.isDataTable('#tblData')) {
        // DataTable is already initialized, destroy it
        $('#tblData').DataTable().destroy();
    }

    var url = window.location.search;
    var status = "";

    if (url.includes("inprocess")) {
        status = "inprocess";
    } else if (url.includes("completed")) {
        status = "completed";
    } else if (url.includes("pending")) {
        status = "pending";
    } else if (url.includes("approved")) {
        status = "approved";
    } else {
        status = "all";
    }

    loadDataTable(status);
    
});


function loadDataTable() {

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
                    
                <a href="/admin/order/details?orderId=${data}" class="btn btn-primary mx-2 bg-info"> <i class="bi bi-pencil-square"></i></a>
                   
                </div > `
                },
                "width": "10%"
            }

        ]
    });

}


