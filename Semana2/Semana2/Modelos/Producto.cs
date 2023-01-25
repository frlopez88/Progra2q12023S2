namespace Semana2.Modelos
{
	public class Producto
	{

		public string nombre {get;set;}
		public double precio {get;set;}
        public string codigoProducto {get;set;}
        public string proveedor {get;set;}

        public string toString(){

            double isv = this.calcularIsv();
            return $"Producto:  {nombre} -  Precio: {precio} - Precio Isv: {isv}";

        }

        public double calcularIsv(){
            
            return precio*1.15;
        
        }

    }
}