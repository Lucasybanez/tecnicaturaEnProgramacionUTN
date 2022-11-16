let inputUser= document.getElementById("usuario");
let inputContra= document.getElementById("contraseña");
let btnLogin= document.getElementById("btnLogin");

init();

function init(){

    let user="Nico";
    let contra="contraseña";
    localStorage.setItem("user",user);
    localStorage.setItem("contraseña",contra);

}

function prueba(){
    let userGuardado=localStorage.getItem("user");
    let contraGuardada=localStorage.getItem("contraseña");

    if(inputUser.value==userGuardado && inputContra.value==contraGuardada){
        window.open("inicio.html");
    } else {
        alert("El usuario o contraseña ingresada no son correctos");
    }
}

btnLogin.onclick=prueba;

