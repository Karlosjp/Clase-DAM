
public class Ejercicio7Admon extends Ejercicio7Per {
	
	//1. variables
	protected char genero;
	protected int extras;
	
	//2. constructor
	public Ejercicio7Admon(String dni, String nombre, String apellidos, double salario, char genero, int extras) {
		super(dni, nombre, apellidos, salario);
		this.genero = genero;
		this.extras = extras;
	}

	//3. get & set
	protected char getGenero() {
		return genero;
	}

	protected void setGenero(char genero) {
		this.genero = genero;
	}

	protected int getExtras() {
		return extras;
	}

	protected void setExtras(int extras) {
		this.extras = extras;
	}

	//4. toString
	@Override
	public String toString() {
		return "Administracion [dni=" + dni + ", nombre=" + nombre + ", apellidos=" + apellidos + ", salario=" + salario
				+ ", genero=" + genero + ", extras=" + extras + "]";
	}
	
	
	
	
	

}
