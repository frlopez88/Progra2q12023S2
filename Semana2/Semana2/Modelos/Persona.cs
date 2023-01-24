
namespace Semana2.Modelos
{
	public class Persona
	{
		private string nombre;
		private DateTime fechaNacimiento;
		private char genero;

		public Persona(string nm, DateTime fn, char g )
		{

			this.nombre = nm;
			this.fechaNacimiento = fn;
			this.genero = g;

		}

		public string getNombre() {

			return this.nombre;
		}

		public void setNombre(string nm) {

			this.nombre = nm;

		}

		public DateTime getFechaNacimiento() {

			return fechaNacimiento;
		}

		public void setFechaNacimiento(DateTime dt) {

			this.fechaNacimiento = dt;
		}

		public char getGenero() {

			return this.genero;
		}

		public void setGenero(char gn) {

			this.genero = gn;
		}

		public int getEdad() {

			int edad = 0;


			edad = 2023 - this.fechaNacimiento.Year;

			return edad;

		}

		public string toString() {

			return $"Nombre: {this.nombre} - Fecha Nacimiento: {this.fechaNacimiento} - Genero:  {this.genero} ";
		}

	}
}

