package ejercicio14;

public class Asignatura {
	private String strNombre;
	private int intEvaluacion;
	private double douNota;
	
	public Asignatura(String strNombre) {
		this.strNombre = strNombre;
		this.douNota= 0;
		this.intEvaluacion = 1;
	}

	public Asignatura(String strNombre, int intEvaluacion, double douNota) {
		this.strNombre = strNombre;
		this.intEvaluacion = intEvaluacion;
		this.douNota = douNota;
	}

	public double getDouNota() {
		return douNota;
	}

	public void setDouNota(double douNota) {
		this.douNota = douNota;
	}
}
