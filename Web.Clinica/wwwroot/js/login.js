﻿$(function (e) {

    //fnComboConexion();

    $("#frmLogin").on("submit", function (e) {
        e.preventDefault();
    });
    //$("#frmLogin").validate();

    $("#btnLogin").click(function () {
        if (validForm() == true) {
            fnLogin();
        }
        else {
            //fnAlertAdvertencia("Ingrese Todos Sus Datos");
            return;
        }
    });

    $("#messageError").hide();

});


function validForm() {
    var flagValid = true;
    if ($("#Login").val() == "") {
        return flagValid = false;
    }
    if ($("#Password").val() == "") {
        return flagValid = false;
    }
    return flagValid;
}





function fnLogin() {

    var parametro = new Object();
    parametro.Login = $("#Login").val();
    parametro.Password = $("#Password").val();


    Post("Lgn/Validate", parametro).done(function (response) {
        console.log(response);
        var result = response.data;
        console.log(result);
        if (result.code == 0) {
            // window.location = fnBaseUrlWeb("Main/Index");

            window.location = fnBaseUrlWeb("Principal/MenuPrincipal");
        } else if (result.code == 1) {
            $("#messageError").html(response.message);
            $("#messageError").show();
        }

    });
}


function fnComboConexion() {
    Get("Main/GetPortalTablas").done(function (response) {

        var Response = response.data;

        console.log(Response);

        if (Response != null) {
            var select = document.getElementById('IdTipoConexion');
            var options = '<option value="">Seleccionar Ambiente</option>';
            for (let item of Response) {
                options += `<option value="${item.id}">${item.dsc_nombre}</option>`;
            }
            select.innerHTML = options;
        }
    });
}