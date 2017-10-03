
public class Ejercicio7Dir extends Ejercicio7Per {
	
	//1. variables
	protected boolean salesiano;
	protected char horario;
	
	//2. constructor
	public Ejercicio7Dir(String dni, String nombre, String apellidos, double salario, boolean salesiano, char horario) {
		super(dni, nombre, apellidos, salario);
		this.salesiano = salesiano;
		this.horario = horario;
	}

	//3. get & set
	protected boolean isSalesiano() {
		return salesiano;
	}

	protected void setSalesiano(boolean salesiano) {
		this.salesiano = salesiano;
	}

	protected char getHorario() {
		return horario;
	}

	protected void setHorario(char horario) {
		this.horario = horario;
	}
	
	//4. toString
	@Override
	public String toString() {
		return "Directivo [dni=" + dni + ", nombre=" + nombre + ", apellidos=" + apellidos + ", salario=" + salario
				+ ", salesiano=" + salesiano + ", horario=" + horario + "]";
	}
	
	
	

}
