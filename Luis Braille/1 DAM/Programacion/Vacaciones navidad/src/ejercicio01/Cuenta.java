package ejercicio01;

public class Cuenta {
	private String strNombre, strNumero;
	private double douInteres, douSaldo;

	/**
	 * Constructor pordefecto
	 */
	public Cuenta() {
		this.strNombre = "";
		this.strNumero = "";
		this.douInteres = 0;
		this.douSaldo = 0;
	}

	/**
	 * Constructor con todos los parametros
	 * 
	 * @param strNombre
	 * @param strNumero
	 * @param douInteres
	 * @param douSaldo
	 */
	public Cuenta(String strNombre, String strNumero, double douInteres, double douSaldo) {
		this.strNombre = strNombre;
		this.strNumero = strNumero;
		this.douInteres = douInteres;
		this.douSaldo = douSaldo;
	}

	/**
	 * Constructor copia
	 * 
	 * @param cuenta
	 */
	public Cuenta(Cuenta cuenta) {
		this.strNombre = cuenta.getStrNombre();
		this.strNumero = cuenta.getStrNumero();
		this.douInteres = cuenta.getDouInteres();
		this.douSaldo = cuenta.getDouSaldo();
	}

	public String getStrNombre() {
		return strNombre;
	}

	public String getStrNumero() {
		return strNumero;
	}

	public double getDouInteres() {
		return douInteres;
	}

	public double getDouSaldo() {
		return douSaldo;
	}

	public void setStrNombre(String strNombre) {
		this.strNombre = strNombre;
	}

	public void setStrNumero(String strNumero) {
		this.strNumero = strNumero;
	}

	public void setDouInteres(double douInteres) {
		this.douInteres = douInteres;
	}

	public void setDouSaldo(double douSaldo) {
		this.douSaldo = douSaldo;
	}

	public boolean ingreso(double douIngreso) {
		boolean booRest = false;

		if (douIngreso >= 0) {
			this.douSaldo += douIngreso;
			booRest = true;
		}

		return booRest;
	}

	public boolean reintegro(double douReintegro) {
		boolean booRest = false;
		
		if (douSaldo >= douReintegro && douReintegro >= 0) {
			douSaldo -= douReintegro;
			booRest = true;
		}

		return booRest;
	}

	public boolean transferencia(Cuenta cuenta, double douImporte) {
		boolean booRest = false;

		if (this.douSaldo >= douImporte && douImporte >= 0) {
			douSaldo -= douImporte;
			cuenta.ingreso(douImporte);
			booRest = true;
		}

		return booRest;
	}

}
