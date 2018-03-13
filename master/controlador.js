
var usuariov = "edwar";
var passw = 23456;

function verificar() {
    var usuario = document.getElementById("user").value;
    var contrasena = document.getElementById("pass").value;
    if (usuario == usuariov && contrasena == passw) {
        alert("puedes seguir ");
    }
}
