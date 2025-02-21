//Nos mostrará el show modal spinner de espera.
function ClearText(nameControlSpinner) {
    document.getElementById(nameControlSpinner).value = "";
}


//Nos mostrará el spinner de espera del control de búsqueda.
function ShowSpinnerSearch(nameControlSpinner, nameControlSearch) {
    document.getElementById(nameControlSearch).style.display = "none";
    document.getElementById(nameControlSpinner).style.display = "block";
}

//Ocultará el spinner y mostrará nuevamente el icono de búsqueda por defecto.
function CloseSpinnerSearch(nameControlSpinner, nameControlSearch) {
    try {
        document.getElementById(nameControlSpinner).style.display = "none";
        document.getElementById(nameControlSearch).style.display = "block";
    }
    catch { }
}

//Nos mostrará el show modal spinner de espera.
function ShowModalSpinner(nameControlSpinner) {
    try {
        document.getElementById(nameControlSpinner).style.display = "flex";
    }
    catch { }
}

//Nos mostrará el show modal spinner de espera.
function CloseModalSpinner(nameControlSpinner) {
    document.getElementById(nameControlSpinner).style.display = "none";
}

//Dar el focus principal del control que queremos.
function focusControl(nameControl) {
    document.getElementById(nameControl).focus();
    document.getElementById(nameControl).click();
}
function CloseSearchFiltroAvazando(nameButtonDropdown) {
    document.getElementById(nameButtonDropdown).click(function (e) {
        e.stopPropagation();

    });
}


/*Esto no se está usando */
var myModal;
var myModalNotFound;

//Mostrar modal de mensaje indicando que no se encontraron resultados.
function NotFoundSpinner(nameControl) {
    myModalNotFound = new bootstrap.Modal(document.getElementById(nameControl), {
        keyboard: false
    })

    myModalNotFound.show();
}


//Mostrar modal de mensaje general.
function ShowMessageModal(EscapeKey, nameControl) {
    myModalNotFound = new bootstrap.Modal(document.getElementById(nameControl), {
        keyboard: EscapeKey
    })

    myModalNotFound.show();
}

//INI REQ 2024-06637
//Abrir Modales 
function ShowModalPopupControl(nameControl) {
    myModalNotFound = new bootstrap.Modal(document.getElementById(nameControl), {
        keyboard: false
    })

    myModalNotFound.show();
}

//Cerrar Modales
function CloseModalMessageName(namecontrol) {

    myModalNotFound.hide();
    document.getElementById(namecontrol).click();
}
//FIN REQ 2024-06637


function ShowModal() {
    myModal = new bootstrap.Modal(document.getElementById('msgModal'), {
        keyboard: false
    })

    //myModal.show();
}

function ShowModal2(ModalSelect) {
    myModal = new bootstrap.Modal(document.getElementById(ModalSelect), {
        keyboard: false
    })

    myModal.show();
}

function CloseModal() {
    //msgModal.hide();
    //return new Promise(resolve => {
    //    resolve(true);
    //})

    //$('#msgModal').on('hide.bs.modal', function (e) { });
    //document.getElementById("msgModal").click();
    myModal.hide();
    document.getElementById("idCloseModal").click();
}


function CloseModalMessage() {
    //msgModal.hide();
    //return new Promise(resolve => {
    //    resolve(true);
    //})

    //$('#msgModal').on('hide.bs.modal', function (e) { });
    //document.getElementById("msgModal").click();
    myModalNotFound.hide();
    document.getElementById("idCloseModal").click();
}

function CloseModalMessageName(Idclose) {   
    myModalNotFound.hide();
    document.getElementById(Idclose).click();
}
 
function CloseDiv(namediv) {
    var x = document.getElementById(namediv);
    if (x.style.display === "none") {
        x.style.display = "block";
    } else {
        x.style.display = "none";
    }
}


function CloseDivModal(namediv) {
    $("#" + namediv).modal("hide");
}

function locationreload() {
    location.reload();
}

function select(idSelect, idText) {
    alert(hola)
    var xidSelect = document.getElementById(idSelect);
    var xidText = d.options[xidSelect.selectedIndex].text;
    document.getElementById(idText).value = xidText;
}

function resetInputFile(inputElement) {
    inputElement.value = '';
}

function ekUploadImagenes() {
    function Init() {

        console.log("Upload Initialised");

        var fileSelect = document.getElementById('file_upload'),
            fileDrag = document.getElementById('file-drag'),
            submitButton = document.getElementById('submit-button');

        fileSelect.addEventListener('change', fileSelectHandler, false);

        // Is XHR2 available?
        var xhr = new XMLHttpRequest();
        if (xhr.upload) {
            // File Drop
            fileDrag.addEventListener('dragover', fileDragHover, false);
            fileDrag.addEventListener('dragleave', fileDragHover, false);
            fileDrag.addEventListener('drop', fileSelectHandler, false);
        }
    }

    function fileDragHover(e) {
        var fileDrag = document.getElementById('file-drag');

        e.stopPropagation();
        e.preventDefault();

        fileDrag.className = (e.type === 'dragover' ? 'hover' : 'modal-body file-upload');
    }

    function fileSelectHandler(e) {
        // Fetch FileList object
        var files = e.target.files || e.dataTransfer.files;

        // Cancel event and hover styling
        fileDragHover(e);

        // Process all File objects
        for (var i = 0, f; f = files[i]; i++) {
            parseFile(f);
            uploadFile(f);
        }
    }

    function parseFile(file) {

        console.log(file.name);
        output(
            '<strong>' + encodeURI(file.name) + '</strong>'
        );

        // var fileType = file.type;
        // console.log(fileType);
        var imageName = file.name;

        var isGood = (/\.(?=gif|jpg|png|jpeg)/gi).test(imageName);
        if (isGood) {
            document.getElementById('start').classList.add("hidden");
            document.getElementById('response').classList.remove("hidden");
            document.getElementById('notimage').classList.add("hidden");
            // Thumbnail Preview
            document.getElementById('file_upload').classList.remove("hidden");
            document.getElementById('file_upload').src = URL.createObjectURL(file);
        }
        else {
            //document.getElementById('file_upload').classList.add("hidden");
            document.getElementById('notimage').classList.remove("hidden");
            document.getElementById('start').classList.remove("hidden");
            document.getElementById('response').classList.add("hidden");
            document.getElementById("file-upload-form").reset();
        }
    }

    function setProgressMaxValue(e) {
        var pBar = document.getElementById('file-progress');

        if (e.lengthComputable) {
            pBar.max = e.total;
        }
    }

    function updateFileProgress(e) {
        var pBar = document.getElementById('file-progress');

        if (e.lengthComputable) {
            pBar.value = e.loaded;
        }
    }

    function uploadFile(file) {

        var xhr = new XMLHttpRequest(),
            fileInput = document.getElementById('class-roster-file'),
            pBar = document.getElementById('file-progress'),
            fileSizeLimit = 1024; // In MB
        if (xhr.upload) {
            // Check if file is less than x MB
            if (file.size <= fileSizeLimit * 1024 * 1024) {
                // Progress bar
                pBar.style.display = 'inline';
                xhr.upload.addEventListener('loadstart', setProgressMaxValue, false);
                xhr.upload.addEventListener('progress', updateFileProgress, false);

                // File received / failed
                xhr.onreadystatechange = function (e) {
                    if (xhr.readyState == 4) {
                        // Everything is good!

                        // progress.className = (xhr.status == 200 ? "success" : "failure");
                        // document.location.reload(true);
                    }
                };

                // Start upload
                xhr.open('POST', document.getElementById('file-upload-form').action, true);
                xhr.setRequestHeader('X-File-Name', file.name);
                xhr.setRequestHeader('X-File-Size', file.size);
                xhr.setRequestHeader('Content-Type', 'multipart/form-data');
                xhr.send(file);
            } else {
                output('Please upload a smaller file (< ' + fileSizeLimit + ' MB).');
            }
        }
    }

    // Check for the various File API support.
    if (window.File && window.FileList && window.FileReader) {
        Init();
    } else {
        document.getElementById('file-drag').style.display = 'none';
    }
}

function cerrarModal(modalId) {
    $('#' + modalId).modal('hide');
}
// wwwroot/js/interop.js
function downloadPdfFile(fileName, fileBytes) {
    const blob = new Blob([fileBytes], { type: "application/pdf" });
    const url = URL.createObjectURL(blob);

    const a = document.createElement("a");
    a.href = url;
    a.download = fileName;

    document.body.appendChild(a);
    a.click();

    document.body.removeChild(a);
    URL.revokeObjectURL(url);
}

function showCustomContextMenu(link) {
    // Lógica para mostrar el menú contextual aquí
    alert("Enlace copiado: " + link);
}



function ArchivoDataDownloadFile(nombreArchivo, base64Archivo)
{
    const link = document.createElement("a");
    link.download = nombreArchivo;
     link.href = "data:application/vnd.ms-excel;base64," + base64Archivo; 
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}
