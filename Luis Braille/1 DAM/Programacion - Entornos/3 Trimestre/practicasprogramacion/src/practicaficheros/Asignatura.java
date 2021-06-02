package practicaficheros;

public class Asignatura {
	private String strNombre;
	private double douNota;

	public Asignatura(String strNombre, double douNota) {
		this.strNombre = strNombre;
		this.douNota = douNota;
	}

	public String getStrNombre() {
		return strNombre;
	}

	public void setStrNombre(String strNombre) {
		this.strNombre = strNombre;
	}

	public double getDouNota() {
		return douNota;
	}

	public void setDouNota(double douNota) {
		this.douNota = douNota;
	}

	@Override
	public String toString() {
		return "Nombre:" + strNombre + "-Nota:" + douNota;
	}

}
