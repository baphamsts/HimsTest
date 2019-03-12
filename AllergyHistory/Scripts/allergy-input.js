// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

$('#allergenTypeSelectBox').change(function (e) {
    console.log($('#allergenTypeSelectBox').val());
    var typeId = $('#allergenTypeSelectBox').val();

    //Medication
    if (typeId == "612") {
        $('#medicationOption').show();
    }
    else {
        $('#medicationOption').hide();
    }

});

$("#submitButton").click(function (e) {
    e.preventDefault();

    var dataObj = {
        typeId: $('#allergenTypeSelectBox').val(),
        severityId: $('#allergenSeveritySelectBox').val(),
        reactionId: $('#allergenReactionSelectBox').val(),
        allergenId: $('#allergenSelectBox').val(),
        drugId: $('#medicationSelectBox').val(),
        notes: $('#noteText').val()
    }

    console.log(data);

    $.ajax({
        type: "POST",
        url: "/imball-reagens/public/shareitem",
        data: dataObj,

        success: function (result) {
           
        }
    });
});


$("#resetButton").click(function (e) {
    $('#allergenTypeSelectBox').val(-1);
    $('#allergenTypeSelectBox').selectpicker('refresh');

    $('#allergenSeveritySelectBox').val(-1);
    $('#allergenSeveritySelectBox').selectpicker('refresh');

    $('#allergenReactionSelectBox').val(-1);
    $('#allergenReactionSelectBox').selectpicker('refresh');

    $('#allergenSelectBox').val(-1);
    $('#allergenSelectBox').selectpicker('refresh');

    $('#medicationSelectBox').val(-1);
    $('#medicationSelectBox').selectpicker('refresh');

    $('#noteText').val("");

});