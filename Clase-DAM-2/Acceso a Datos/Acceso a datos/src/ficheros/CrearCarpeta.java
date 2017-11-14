package ficheros;

import java.io.File;

public class CrearCarpeta {

	String CNombre;

	File carpeta = new File(CNombre);

	public CrearCarpeta(String cNombre) {
		CNombre = cNombre;
	}

}
