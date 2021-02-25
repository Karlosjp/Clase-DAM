package tema5.ejercicio2;

public class Empleado extends Persona {
	protected double douSueldoBruto;

	public Empleado(String strNombre, int intEdad, double douSueldoBruto) {
		super(strNombre, intEdad);

		this.douSueldoBruto = douSueldoBruto;
	}

	@Override
	public void mostrar() {
		super.mostrar();

		System.out.println("Sueldo bruto: " + douSueldoBruto);
	}

	public double calcularSalarioNeto() {
		double douSalarioNeto = 0;

		return douSalarioNeto;
	}
}
