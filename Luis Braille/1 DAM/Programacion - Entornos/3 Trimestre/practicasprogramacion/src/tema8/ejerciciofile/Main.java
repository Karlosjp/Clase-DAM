package tema8.ejerciciofile;

import java.io.File;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		File objFile = new File(".");
		Scanner scaner = new Scanner(System.in);
		int strContinuar = 0;
		String strRutaActual;

		do {

			System.out.println("Ahora te encuentras en: " + objFile.getAbsolutePath());
			System.out.println("¿Que quieres hacer?");
			System.out.println(" 1 - Desplazar \n 2 - Renombrar \n 3 - Crear \n 0 - Salir");
			strContinuar = Integer.parseInt(scaner.nextLine());

			strRutaActual = (new File(objFile.getAbsolutePath())).getAbsolutePath();
			if (strRutaActual.charAt(strRutaActual.length() - 1) == '.')
				strRutaActual = strRutaActual.substring(0, strRutaActual.lastIndexOf(File.separatorChar));

			switch (String.valueOf(strContinuar)) {
			case "1":
				objFile = desplazar(objFile, scaner, strRutaActual);
				break;
			case "2":
				break;
			case "3":
				if (crearCarpeta(strRutaActual, scaner))
					System.out.println("La carpeta ha sido creada");
				else
					System.out.println("Error al crear carpeta");
				break;
			default:
				break;
			}
		} while (strContinuar != 0);
	}

	public static File desplazar(File objFile, Scanner scn, String strRutaActual) {
		int intOpcion = 0;
		ArrayList<String> alListaDirectorios = new ArrayList();
		String strRutaPadre = (new File(objFile.getAbsolutePath())).getParent();
		String[] arrStr = objFile.list();

		alListaDirectorios.add(new File(strRutaActual).getParent());

		for (int intI = 0; intI < arrStr.length; intI++)
			if ((new File(objFile.getAbsolutePath(), arrStr[intI])).isDirectory() && arrStr[intI].charAt(0) != '.')
				alListaDirectorios.add(arrStr[intI]);

		do {
			System.out.println(
					"Opciones disponibles, selecciona el numero al que quieres ir. Estas en \n" + strRutaActual);
			for (int intI = 0; intI < alListaDirectorios.size(); intI++)
				System.out.print(" " + intI + ".- " + alListaDirectorios.get(intI) + "\t");
			System.out.println();

			intOpcion = scn.nextInt();
		} while (intOpcion < 0 || intOpcion > alListaDirectorios.size());

		if (intOpcion == 0) {
			objFile = new File(alListaDirectorios.get(0));
		} else if (intOpcion > 0 || intOpcion <= alListaDirectorios.size() - 1)
			objFile = new File(strRutaActual + File.separatorChar + alListaDirectorios.get(intOpcion));
		else
			System.out.println("Directorio no encontrado");

		return objFile;
	}

	private static boolean crearCarpeta(String strRuta, Scanner scn) {
		File objFile = null;
		String strNombreCarpeta = "";

		System.out.println("Escribe el nombre de la carpeta (0 - Salir)");
		strNombreCarpeta = scn.nextLine();

		if (strNombreCarpeta.equals("0"))
			return false;

		try {
			objFile = new File(strRuta + File.separatorChar + strNombreCarpeta);
			return objFile.mkdir();
		} catch (Exception e) {
			// TODO: handle exception
		}

		return false;
	}
}
