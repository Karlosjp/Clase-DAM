package examen.ejercicio3;

public class Combustion extends Vehiculo {
	private double douCilindrada;

	public Combustion(double douCilindrada) {
		this.douCilindrada = douCilindrada;
	}

	@Override
	public double impuesto() {
		return douCilindrada * 3;
	}
}
