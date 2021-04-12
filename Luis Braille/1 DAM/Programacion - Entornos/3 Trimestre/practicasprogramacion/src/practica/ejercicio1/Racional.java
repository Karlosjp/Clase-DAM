package practica.ejercicio1;

public class Racional {
	private double douNumerador, douDenominador;

	public Racional(double douNumerador, double douDenominador) {
		this.douNumerador = douNumerador;
		this.douDenominador = douDenominador;
	}

	@Override
	public String toString() {
		return "Racional [douNumerador=" + douNumerador + ", douDenominador=" + douDenominador + "]";
	}

	public double getDouNumerador() {
		return douNumerador;
	}

	public double getDouDenominador() {
		return douDenominador;
	}

	public int comparar(Racional objRacional) {
		if (this.calcular() > objRacional.calcular())
			return 1;
		else if (this.calcular() < objRacional.calcular())
			return -1;
		else
			return 0;

	}

	private double calcular() {
		return douNumerador / douDenominador;
	}
}
