using Semana2.Modelos;

DateTime fecha = new DateTime(1985, 02, 05);
Persona p = new Persona("Cristiano Ronaldo", fecha, 'M');
Persona p2 = new Persona("Leonel Messi", new DateTime(1988, 8, 30), 'M');
Persona p3 = new Persona("Alex Morgan", new DateTime(1990, 1, 1), 'F');

List<Persona> listaP = new List<Persona>();

p.setNombre("Neymar Jr");

listaP.Add(p);
listaP.Add(p2);
listaP.Add(p3);


foreach (Persona x in listaP) {

    int edad=  x.getEdad();
    Console.WriteLine(x.toString()  + " - Edad: "+ edad);

}


Producto pr1 = new Producto() {

    nombre = "Laptop",
    codigoProducto = "LP01",
    precio =  800,
    proveedor = "Samsung"

};

Producto pr2 = new Producto() {

    nombre = "Iphone 12",
    codigoProducto  = "IPH12",
    precio = 1200,
    proveedor = "Apple"

};

pr1.nombre = "Laptop Touch"; 


List<Producto> listaProductos = new List<Producto>();

listaProductos.Add(pr1);
listaProductos.Add(pr2);


foreach (Producto x in listaProductos) {

    Console.WriteLine(x.toString());

}
