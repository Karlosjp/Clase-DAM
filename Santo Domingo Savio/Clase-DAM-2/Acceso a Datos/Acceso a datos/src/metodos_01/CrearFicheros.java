package metodos_01;

import java.io.File;
import java.io.IOException;

class CrearFicheros {

	public static void main(String[] args) {
		File fichero = new File("z:hola.txt");

		try {
			if (fichero.createNewFile())
				System.out.println("El fichero se ha creado");
			else
				System.out.println("El ficjero no se ha creado");
		} catch (IOException e) {
			e.printStackTrace();
		}

	}

}
