package metodos_01;

import ejerciciosFecha.Fecha;

public class MetodosClase {

	public static void main(String[] args) {
		Fecha f1;
		f1 = crearFecha();
		System.out.println(f1.escribirCorto());

	}

	private static Fecha crearFecha() {
		return new Fecha();
	}

}
