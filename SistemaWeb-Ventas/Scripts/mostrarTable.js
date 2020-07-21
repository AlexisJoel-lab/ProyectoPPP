$(document).ready(function () {
    $("#Hide").hide();

    $("#btnCancelar").click(function (e) {
        e.preventDefault();
        $("#Hide").hide('slow');
        limpiarFormCliente();
    });

    $("#btnShowForm").click(function (e) {
        e.preventDefault();
        $("#Hide").show('slow');
    });
});


function limpiarFormCliente() {
    $('#txtNombre').val('');
    $('#txtApePaterno').val('');
    $('#txtApeMaterno').val('');
    $('#txtDNI').val('');
    //$('input:radio[name=ctl00$MainContent$rbtGroupGenero]').attr('checked', false);
    $("#rbtMales").attr('checked', false);
    $("#rbtFemale").attr('checked', false);
    $('#txtTelefono').val('');
    $('#txtDireccion').val('');
    $('#txtEmail').val('');
    $("#cbEstado option:selected").text();
    $('#txtNombre').Focus();
}