// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    var dataTable = $("#example").DataTable({
        "processing": true, // for show progress bar
        "serverSide": true, // for process server side
        "filter": true, // this is for disable filter (search box)
        "ordering": false,
        "language": {
            search: '',
            searchPlaceholder: "Search by Patient"
        },

        "lengthMenu": [[10, 25, 50, 100, -1], [10, 25, 50, 100, "All"]],

        "ajax": {
            "url": "/home/loadDataXml",
            "type": "POST",
            "datatype": "json"
        },
    
        "columns": [
            { "data": "Id", "name": "Id", "autoWidth": true, "className": "hide_column" },
            { "data": "AllergenId", "name": "AllergenId", "autoWidth": true, "className": "hide_column" },
            { "data": "AllergenType", "name": "AllergenType", "autoWidth": true, "className": "hide_column" },
            { "data": "ReactionId", "name": "ReactionId", "autoWidth": true, "className": "hide_column" },
            { "data": "SeverityId", "name": "SeverityId", "autoWidth": true, "className": "hide_column" },
            { "data": "Patient", "name": "Patient", "autoWidth": true },
            { "data": "Type", "name": "Type", "autoWidth": true },
            { "data": "Allergen", "name": "Allergen", "autoWidth": true },
            { "data": "Reaction", "name": "Reaction", "autoWidth": true },
            { "data": "Serverty", "name": "Serverty", "autoWidth": true },
            { "data": "Notes", "name": "Notes", "autoWidth": true },
            { "data": "CreateInfo", "name": "CreateInfo", "autoWidth": true },
            { "data": "UpdateInfo", "name": "UpdateInfo", "autoWidth": true },
            {
                data: null, render: function (data, type, row) {

                    return "<a href='#' class='btn btn-inf' onclick=\"EditDataInput("
                        //+ row.typeId + ',' +
                        + row.AllergenId + ','
                        + row.ReactionId + ','
                        + row.SeverityId + ",'"
                        + row.Notes + "')\">Edit</a>";

                }
            },
        ],
        dom: '<"allergy-searchbox col-md-6 col-sm-12"f><"allergy-table-button"B>rt<"allergy-table-len"l>ip',
        buttons: [
            {
                extend: 'print',
                text: 'Preview',
                autoPrint: false,
                customize: function (win) {
                    $(win.document.body)
                        .css('font-size', '10pt');

                    $(win.document.body).find('table')
                        .addClass('compact')
                        .css('font-size', 'inherit');
                }
            },
            {
                extend: 'print',
                text: 'Print',
                customize: function (win) {
                    $(win.document.body)
                        .css('font-size', '10pt');

                    $(win.document.body).find('table')
                        .addClass('compact')
                        .css('font-size', 'inherit');
                },
                className: 'btn default',
                oSelectorOpts: {
                    page: 'all'
                },
                bShowAll: true,
                sAjaxSource: "/home/loadData"
            },
            {
                extend: 'excelHtml5',
                text: 'Excel',
                exportOptions: {
                    modifier: {
                        page: 'all'
                    }
                }
            },
            {
                extend: 'pdfHtml5',
                text: 'PDF',
                exportOptions: {
                    modifier: {
                        page: 'all'
                    }
                }
            }
        ]
    });

    $('.selectpicker').selectpicker();
});

function EditDataInput(allergenId, reactionId, severityId, notes) {
    $('#allergenTypeSelectBox').val(-1);
    $('#allergenTypeSelectBox').selectpicker('refresh');

    $('#allergenSeveritySelectBox').val(severityId);
    $('#allergenSeveritySelectBox').selectpicker('refresh');

    $('#allergenReactionSelectBox').val(reactionId);
    $('#allergenReactionSelectBox').selectpicker('refresh');

    $('#allergenSelectBox').val(allergenId);
    $('#allergenSelectBox').selectpicker('refresh');

    $('#medicationSelectBox').val(-1);
    $('#medicationSelectBox').selectpicker('refresh');

    $('#noteText').val(notes);
}


