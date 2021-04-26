package tema8.ejerciciofile;

import java.io.File;
import java.util.ArrayList;
import java.util.Scanner;

public class Main2 {

	public static void main(String[] args) {
		File objFile = new File(".");
		Scanner scaner = new Scanner(System.in);
		String strContinuar = "0", strRutaActual;

		do {

			System.out.println("Ahora te encuentras en: " + objFile.getAbsolutePath());
			System.out.println("¿Que quieres hacer?");
			System.out.println(" 1 - Desplazar \n 2 - Renombrar \n 3 - Crear \n 0 - Salir");
			strContinuar = scaner.nextLine();

			strRutaActual = (new File(objFile.getAbsolutePath())).getAbsolutePath();
			if (strRutaActual.charAt(strRutaActual.length() - 1) == '.')
				strRutaActual = strRutaActual.substring(0, strRutaActual.lastIndexOf(File.separatorChar));

			

			switch (strContinuar) {
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
		} while (strContinuar != "0");
	}

	public static File desplazar(File objFile, Scanner scn, String strRutaActual) {
		int intNumero = 0, intOpcion = 0;
		ArrayList<String> alListaDirectorios = new ArrayList<String>();
		String strRutaPadre = (new File(objFile.getAbsolutePath())).getParent();
		String[] arrStr = objFile.list();

		alListaDirectorios
				.add("..");
		
		if (arrStr != null)
			for (String strLista : arrStr)
				if ((new File(objFile.getAbsolutePath(), strLista)).isDirectory() && strLista.charAt(0) != '.')
					alListaDirectorios.add(strLista);

		System.out.println("Opciones disponibles, selecciona el numero al que quieres ir. Estas en " + strRutaActual);
//		System.out.print(" " + intNumero++ + ".- Volver atras");
		for (String strDirectorio : alListaDirectorios)
			System.out.print(" " + intNumero++ + ".- " + strDirectorio + "\t");
		System.out.println();
		
		intOpcion = scn.nextInt();

		if (intOpcion == 0) {
			objFile = new File(strRutaPadre);
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

	private static File desplazar(Scanner scnLeer, File fichero) {
		String[] arrStrListaArchivos = fichero.list();
		String strUbicaionAct = (new File(fichero.getAbsolutePath())).getAbsolutePath();

		if (strUbicaionAct.charAt(strUbicaionAct.length() - 1) == '.')
			strUbicaionAct = strUbicaionAct.substring(0, strUbicaionAct.lastIndexOf(File.separatorChar));

		ArrayList<String> alDirectorios = new ArrayList();

		int intOpc;

		System.out.println("Se encuentra en " + strUbicaionAct);

		// inserto el diectorio raiz del actual
		alDirectorios.add(new File(strUbicaionAct).getParent());
		/*
		 * $$ System.out.println("0.- " + alDirectorios.get(0)); int intDirectorios=1;
		 */
		// paso por los subdirectorios
		for (int intCont = 0; intCont < arrStrListaArchivos.length; intCont++) {
			// si es un subdirectorio lo muestro y añado al arraylist
			if ((new File(strUbicaionAct, arrStrListaArchivos[intCont])).isDirectory() == true) {
				/*
				 * $$ System.out.println(intDirectorios + ".- "+ arrStrListaArchivos[intCont]);
				 * intDirectorios++;
				 */
				alDirectorios.add(arrStrListaArchivos[intCont]);
			}
		}
		for (int intCont = 0; intCont < alDirectorios.size(); intCont++)
			System.out.println(intCont + ".- " + alDirectorios.get(intCont)); // imprimo las opciones
		do {
			System.out.println("Elija el directorio al que quiere ir ente 0 y "
					+ (alDirectorios.size() - 1));/* $$(intDirectorios-1)); */
			intOpc = Integer.parseInt(scnLeer.nextLine());
		} while (intOpc < 0 || intOpc > alDirectorios.size());/* $$intDirectorios); */
		if (intOpc == 0)
			fichero = new File(alDirectorios.get(0));
		else
			fichero = new File(strUbicaionAct + File.separatorChar + alDirectorios.get(intOpc));

		System.out.println("Ubicación actual: " + fichero.getAbsolutePath());
		return fichero;
	}
}
