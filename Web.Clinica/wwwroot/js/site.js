// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function btnclickinputbuscar(nameInput, namebustton) {
    var input = document.getElementById(nameInput);

    // Execute a function when the user presses a key on the keyboard
    input.addEventListener("keypress", function (event)
    {

        // If the user presses the "Enter" key on the keyboard
        if (event.key === "Enter")
        {
            var document = document.getElementById(nameInput).val;
            // Cancel the default action, if needed
            event.preventDefault();
            // Trigger the button element with a click
            document.getElementById(namebustton).click();
        }
    });
}

function initializeSelect2() {
    $("#selectCampos").select2({
        placeholder: "Seleccione un campo",
    });
}