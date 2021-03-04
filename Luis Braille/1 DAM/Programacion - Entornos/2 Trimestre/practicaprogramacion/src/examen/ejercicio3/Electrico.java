package examen.ejercicio3;

public class Electrico extends Vehiculo {
	private double douPrecio;

	public Electrico(double douPrecio) {
		this.douPrecio = douPrecio;
	}

	@Override
	public double impuesto() {
		return douPrecio * 1.09;
	}
}
