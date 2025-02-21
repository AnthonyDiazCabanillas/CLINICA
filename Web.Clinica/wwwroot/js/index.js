document.addEventListener("DOMContentLoaded", function (event) {

    const showNavbar = (toggleId, navId, bodyId, headerId) => {
        const toggle = document.getElementById(toggleId),
            nav = document.getElementById(navId),
            bodypd = document.getElementById(bodyId),
            headerpd = document.getElementById(headerId)

        // Validate that all variables exist
        if (toggle && nav && bodypd && headerpd) {
            toggle.addEventListener('click', () => {
                if (dataUser == false) {
                    if (window.innerWidth >= 768) {
                        document.getElementById("footerPortal").style.width = "calc(100% - var(--nav-width) - 156px)";
                        document.getElementById("dvDataUser").style.display = "";
                        document.getElementById("dvDataUserInitial").style.display = "none";
                        document.getElementById("dvDataUserProfile").style.width = "95%";
                        document.getElementById("dvDataUserclose").style.display = "";
                        document.getElementById("dvDataUserInitialclose").style.display = "none";
                        document.getElementById("dvDataUserProfileclose").style.width = "95%";
                    }
                    dataUser = true;
                }
                else {
                    document.getElementById("dvDataUser").style.display = "none";
                    document.getElementById("dvDataUserInitial").style.display = "";
                    document.getElementById("dvDataUserProfile").style.width = "40px";

                    document.getElementById("dvDataUserclose").style.display = "none";
                    document.getElementById("dvDataUserInitialclose").style.display = "";
                    document.getElementById("dvDataUserProfileclose").style.width = "40px";

                    document.getElementById("footerPortal").style.width = "calc(100% - var(--nav-width))";

                    dataUser = false;
                }


                // show navbar
                nav.classList.toggle('show_sidebar')
                // change icon
                toggle.classList.toggle('bx-x')
                // add padding to body
                bodypd.classList.toggle('body-pd')
                // add padding to header
                headerpd.classList.toggle('body-pd')
            })
        }
    }

    showNavbar('header-toggle', 'nav-bar', 'body-pd', 'header')

    /*===== LINK ACTIVE =====*/
    const linkColor = document.querySelectorAll('.nav_link')

    function colorLink() {
        if (linkColor) {
            linkColor.forEach(l => l.classList.remove('active'))
            this.classList.add('active')
        }
    }
    linkColor.forEach(l => l.addEventListener('click', colorLink))

    // Your code to run since DOM is loaded and ready    
});

function ShowMenuPrincipal(showPrincipal) {
    if (showPrincipal == false) {
        document.getElementById("nav-bar").style.display = "none";
        document.getElementById("header").style.display = "none";
        document.getElementById("footerPortal").style.display = "none";
    }
    else {
        document.getElementById("nav-bar").style.display = "";
        document.getElementById("header").style.display = "";
        document.getElementById("footerPortal").style.display = "";
    }
}

function btnImprimir() {
    window.print();
}

function fnActualizarTitulo(name) {
    document.getElementById("TitleView").innerText = name;
    document.title = name + ": CSF";
}

function SignInCSF(email, password, redirect) {

    var url = "account/login";
    var xhr = new XMLHttpRequest();

    // Initialization
    xhr.open("POST", url);
    xhr.setRequestHeader("Accept", "application/json");
    xhr.setRequestHeader("Content-Type", "application/json");

    // Catch response
    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4) // 4=DONE 
        {
            //console.log("Call '" + url + "'. Status " + xhr.status);
            //if (redirect)
            //    location.replace(redirect);
        }
    };

    // Data to send
    var data = {
        email: email,
        password: password
    };

    // Call API
    xhr.send(JSON.stringify(data));
}

//JVALVERDE - 07/06/2023 - ELIMINAR ELEMENTOS HTML SIN PERMISOS
function eliminarElementosHtml(arrayPermisos) {
    //debugger;
    var arrayElementos = document.querySelectorAll('[data-permiso]');
    if (arrayPermisos.length > 0) {
        if (arrayElementos.length > 0) {
            for (i = 0; i < arrayElementos.length; i++) {
                if (arrayPermisos.filter(x => x.codOpcion.trim() == arrayElementos[i].dataset.permiso).length == 0) {
                    arrayElementos[i].dataset.permiso = 'ELIMINAR';
                }
            }
        }

        arrayElementos = document.querySelectorAll('[data-permiso="ELIMINAR"]');
        for (element of arrayElementos) {
            element.remove();
        }

        //ELEMENT DISABLED
        arrayElementos = document.querySelectorAll('[data-enabled]');
        if (arrayElementos.length > 0) {
            for (i = 0; i < arrayElementos.length; i++) {
                if (arrayPermisos.filter(x => x.codOpcion == arrayElementos[i].dataset.enabled).length == 0) {
                    arrayElementos[i].disabled = true;
                    arrayElementos[i].onmousedown = function () {
                        return false;
                    };
                    arrayElementos[i].onkeypress = function () {
                        return false;
                    };

                }
            }
        }
    } else { //eliminar y bloquear todo
        for (element of arrayElementos) {
            element.remove();
        }
        //ELEMENT DISABLED
        arrayElementos = document.querySelectorAll('[data-enabled]');
        if (arrayElementos.length > 0) {
            for (i = 0; i < arrayElementos.length; i++) {
                arrayElementos[i].disabled = true;
                arrayElementos[i].onmousedown = function () {
                    return false;
                };
                arrayElementos[i].onkeypress = function () {
                    return false;
                };
            }
        }
    }


}
