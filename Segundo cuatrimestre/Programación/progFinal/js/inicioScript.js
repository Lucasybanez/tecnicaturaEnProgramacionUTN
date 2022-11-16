let btnMenu = document.getElementById("btnboton");
let menu = document.getElementById("desplegable");
var estado=1;


iniciar();

function iniciar(){
    let producto;
    let id= localStorage.getItem("id");
    for (var i=0; i<=id;i++){
        producto=recuperar_productos(i);
        cargarProductos(producto.id,producto.nombre,producto.descripcion,producto.precio);
    }
}

function actMenu(){

    if (estado==1){
        menu.style="display: none";
        estado=0;
    } else {
        menu.style="display: block";
        estado=1;
    }

}



function cargarProductos(id,nombre,descripcion,precio){

    const listado = document.getElementById("contProductos");
    const contenidoPasado = listado.innerHTML;

    const contenido=
    `${contenidoPasado}
     <div class="productos__c1"> <!-- Caja de productos -->
    <img src="./img/prote.jpg" alt="" class="productos__c1__img">
    <p>ID: ${id}</p>
    <p>${nombre}</p>
    <p>${descripcion}</p>
    <p>${precio}</p>
</div> `;

    listado.innerHTML=contenido;
    
}



function recuperar_productos(numeroProducto){

    let todosProductos= JSON.parse(localStorage.getItem("productos"));
    const productRecuperado = Object.assign(todosProductos[numeroProducto]);
    return productRecuperado;
   
}

function agregarAFactura(){
    
}


btnMenu.onclick=actMenu;