package tema5.ejercicio2;

public class Directivo extends Empleado {
	private String strCategoria;

	public Directivo(String strNombre, int intEdad, double douSueldoBruto, String strCategoria) {
		super(strNombre, intEdad, douSueldoBruto);

		this.strCategoria = strCategoria;
	}

	@Override
	public void mostrar() {
		super.mostrar();

		System.out.println("Categoria: " + strCategoria);
	}
}
