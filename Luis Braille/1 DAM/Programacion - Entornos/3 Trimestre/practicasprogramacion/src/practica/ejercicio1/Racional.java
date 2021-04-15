package practica.ejercicio1;

public class Racional implements Mayor<Racional> {
	private double douNumerador, douDenominador;

	public Racional(double douNumerador, double douDenominador) {
		this.douNumerador = douNumerador;
		this.douDenominador = douDenominador;
	}

	public double getDouNumerador() {
		return douNumerador;
	}

	public double getDouDenominador() {
		return douDenominador;
	}

	private double calcular() {
		return douNumerador / douDenominador;
	}

	@Override
	public boolean mayor(Racional ojbComparar) {
		if (this.calcular() > ojbComparar.calcular())
			return true;
		else
			return false;
	}

	@Override
	public String toString() {
		return "Racional [douNumerador=" + douNumerador + ", douDenominador=" + douDenominador + "]";
	}
}
