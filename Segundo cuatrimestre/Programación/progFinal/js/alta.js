let id = 0;
let inputNombre=document.getElementById("inName");
let inputDescrip=document.getElementById("inDescrip");
let inputPrecio=document.getElementById("inPrecio");
let btnAlta= document.getElementById("btnAlta");
let vectorAlmacenador = [];

function Producto(id,nombre, descripcion, precio) {

        this.id=id;
        this.nombre=nombre;
        this.descripcion=descripcion;
        this.precio=precio;

}

function guardar(){
    // Guarda el producto
    let objetoProducto = new Producto(id,inputNombre.value,inputDescrip.value,inputPrecio.value);
    // Guarda el objeto en un vector de objetos
    vectorAlmacenador.push(objetoProducto);
    localStorage.setItem("productos",JSON.stringify(vectorAlmacenador));
    localStorage.setItem("id",id);
    id++;
}

btnAlta.onclick=guardar;
