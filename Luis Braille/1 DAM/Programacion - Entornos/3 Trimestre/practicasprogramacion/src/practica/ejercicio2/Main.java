package practica.ejercicio2;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.Scanner;

public class Main {
	/**
	 * 2.- Generar un diccionario de español a inglés por medio de un mapa. Puede
	 * haber varias palabras que se traduzcan al ingles de la misma forma como
	 * pueden ser: tienda shop, store; llegar come, arrive; medio center, middle...
	 * Se irán pidiendo palabras para sacar sinónimos. Si la palabra no existe nos
	 * ofrece meterla en el diccionario Si la palabra existe pero no tiene sinónimos
	 * nos permite meter sinónimos. Si la palabra existe y tiene sinónimos nos los
	 * muestra. Preguntar si quiere introducir más palabras o quiere salir
	 * 
	 * @param args
	 */
	public static void main(String[] args) {
		List<Palabra> liSignificados = new ArrayList<Palabra>();
		liSignificados.add(new Palabra("tienda", "es"));
		liSignificados.add(new Palabra("llegar", "es"));
		liSignificados.add(new Palabra("medio", "es"));

		liSignificados.add(new Palabra("shop", "en", liSignificados.get(0)));
		liSignificados.add(new Palabra("store", "en", liSignificados.get(0)));

		liSignificados.add(new Palabra("come", "en", liSignificados.get(1)));
		liSignificados.add(new Palabra("arrive", "en", liSignificados.get(1)));

		liSignificados.add(new Palabra("center", "en", liSignificados.get(2)));
		liSignificados.add(new Palabra("middle", "en", liSignificados.get(2)));

		liSignificados.get(0).agregarSignificado(liSignificados.get(3));
		liSignificados.get(0).agregarSignificado(liSignificados.get(4));
		liSignificados.get(1).agregarSignificado(liSignificados.get(5));
		liSignificados.get(1).agregarSignificado(liSignificados.get(6));
		liSignificados.get(2).agregarSignificado(liSignificados.get(7));
		liSignificados.get(2).agregarSignificado(liSignificados.get(8));

		Diccionario objDiccionario = new Diccionario(liSignificados);
		boolean booContinuar = true;
		Scanner snc = new Scanner(System.in);
		String strRespuesta = "";

		do {
			System.out.println("Escribe una palabra:");
			strRespuesta = snc.nextLine();

			mostrarPalabra(objDiccionario, strRespuesta);

			System.out.println("Quieres terminar?");
			strRespuesta = snc.nextLine();
			if (strRespuesta.equals("si"))
				booContinuar = false;

		} while (booContinuar);

		System.out.println("Programa terminado");
	}

	public static void mostrarPalabra(Diccionario objDiccionario, String strPalabra) {
		Palabra objPalabra = objDiccionario.existePalabra(strPalabra);
		List<String> liSinonimos = new ArrayList<String>();

		if (objPalabra != null) {
			liSinonimos = buscarSinonimos(objPalabra, objDiccionario);
			
			System.out.println(objPalabra);
			System.err.print("Sinonimos: ");
			for (String strSinonimo : liSinonimos) 
				System.out.print(strSinonimo + "\t");
			
		} else
			System.out.println("La palabra no existe");
		System.out.println();
	}

	public static List<String> agregarSignificados() {
		Scanner scn = new Scanner(System.in);
		String strRespuesta = "";
		boolean booContinue = true;
		List<String> liSignificados = new ArrayList<String>();

		do {
			System.out.println("Escribe un significado (1 para salir)");
			strRespuesta = scn.nextLine();

			if (strRespuesta.equals("1"))
				booContinue = false;
			else
				liSignificados.add(strRespuesta);

		} while (booContinue);

		return liSignificados;
	}

	public static void agregarSinonimos(Palabra objPalabra, Diccionario objDiccionario) {
		boolean booTerminar = false;
		Scanner scn = new Scanner(System.in);
		String strRespuesta = "";
		List<Palabra> liPalabras = new ArrayList<Palabra>();
		Palabra objSignificado = new Palabra();

		System.out.println("significados de la palabra " + objPalabra.getStrPalabra());
		System.out.println("¿Escribe el significado?");
		for (Palabra objSig : objPalabra.getLiSignificados())
			System.out.println("Significado: " + objSig.getStrPalabra());
		strRespuesta = scn.nextLine();

		objSignificado = objDiccionario.existePalabra(strRespuesta);
		if (objSignificado == null) {
			if (objPalabra.getStrIdioma().equals("es"))
				objSignificado = new Palabra(strRespuesta, "en", objPalabra);
			else
				objSignificado = new Palabra(strRespuesta, "es", objPalabra);

			objDiccionario.annadirPalabra(objSignificado);
			objDiccionario.agregarSignificado(objSignificado, objPalabra.getStrPalabra());
		}

		do {
			System.out.println(
					"Escribe un sinonimo para " + objPalabra.getStrPalabra() + ": " + objSignificado.getStrPalabra());
			strRespuesta = scn.nextLine();

			Palabra existePalabra = objDiccionario.existePalabra(strRespuesta);

			if (existePalabra != null)
				liPalabras.add(existePalabra);

			System.out.println("¿Agregar mas sinonimos? Si/No");
			strRespuesta = scn.nextLine();

			if (strRespuesta.equals("Si"))
				booTerminar = true;

		} while (booTerminar);

//		objDiccionario.agregarSinonimo(liPalabras, objPalabra.getStrPalabra());
	}

	/**
	 * Recibe un String y busca sinonimos en el diccionario
	 * 
	 * @param strPalabra
	 * @param objDiccionario
	 * @return devuelve una lista de los sinonimos o null
	 */
	public static List<String> buscarSinonimos(Palabra objPalabra, Diccionario objDiccionario) {

		return objDiccionario.buscarSinonimos(objPalabra);
	}
}
