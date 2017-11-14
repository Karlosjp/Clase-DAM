package examen;

public class Main {

	public static void main(String[] args) {
		GestionProductos gp = new GestionProductos();

		gp.leerFichero("Productos.txt");
		gp.separarProductos();
		gp.imprimir();
	}

}
