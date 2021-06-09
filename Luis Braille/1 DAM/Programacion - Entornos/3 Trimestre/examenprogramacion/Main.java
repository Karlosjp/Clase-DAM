package examenordinario;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.Scanner;
import java.util.TreeMap;

public class Main {

	private static List<String> liIdioma = new ArrayList<String>();
	private static Date objFecha = new Date();
	private static int intPartida = 0, intTurno = 0;

	public static void main(String[] args) {
		int[][] tablero = new int[3][3];

		tablero[0][0] = -1;
		tablero[0][1] = -1;
		tablero[0][2] = -1;

		tablero[1][0] = -1;
		tablero[1][1] = -1;
		tablero[1][2] = -1;

		tablero[2][0] = -1;
		tablero[2][1] = -1;
		tablero[2][2] = -1;

		traducirJuego();
		jugar(tablero);

	}

	// Inicia el juego
	public static void jugar(int[][] tablero) {
		intPartida++;
		int intJugador;

		while (true) {
			mostrarTablero(tablero);

			intTurno++;
			intJugador = intTurno % 2;

			System.out.println("Turno del jugador (" + liIdioma.get(0) + ")" + (intJugador));
			if (intTurno <= 6) {
				if (!posicionaFicha(tablero, intJugador, null)) {
					intTurno--;
					System.out.println("Repite (" + liIdioma.get(1) + ")");
				}
			} else if (!mueveJugador(tablero, intJugador)) {
				intTurno--;
				System.out.println("Repite (" + liIdioma.get(1) + ")");
			}

			int resultado = contarPuntos(tablero, intJugador);

			if (resultado != -1) {
				System.out.println("El ganador es: Jugador " + intJugador);
				break;
			}
		}

	}

	// Calcula si el jugador intJugador ha ganado
	public static int contarPuntos(int[][] tablero, int intJugador) {
		int intContador = 0;

		// Busca ganador en horizontal
		for (int intX = 0; intX < tablero.length; intX++) {
			for (int intY = 0; intY < tablero[intX].length; intY++) {
				if (tablero[intX][intY] == intJugador)
					intContador++;
				else {
					intContador = 0;
					break;
				}

				if (intContador == 3)
					return intJugador;
			}
		}

		// Busca ganador en vertical
		for (int intY = 0; intY < tablero.length; intY++) {
			for (int intX = 0; intX < tablero.length; intX++) {
				if (tablero[intX][intY] == intJugador)
					intContador++;
				else {
					intContador = 0;
					break;
				}

				if (intContador == 3)
					return intJugador;
			}
		}

		// Busca ganador en diagonal
		if (tablero[1][1] == intJugador && tablero[0][0] == intJugador && tablero[2][2] == intJugador)
			return intJugador;
		if (tablero[1][1] == intJugador && tablero[0][2] == intJugador && tablero[2][0] == intJugador)
			return intJugador;

		return -1;
	}

	// Muestra el tablero de juego
	public static void mostrarTablero(int[][] tablero) {
		for (int intX = 0; intX < tablero.length; intX++) {
			for (int intY = 0; intY < tablero[intX].length; intY++)
				System.out.print(tablero[intX][intY] + "\t");

			System.out.println("");
		}
	}

	// Si reposiciona una ficha
	public static boolean mueveJugador(int[][] tablero, int intJugador) {
		Scanner scn = new Scanner(System.in);
		int intX, intY;

		System.out.println("Que ficha quieres mover? (" + liIdioma.get(2) + ")");

		intX = introduceNumero('X');
		intY = introduceNumero('Y');

		int[] arrPos = { intX, intY };

		if (tablero[intX][intY] == intJugador) {
			tablero[intX][intY] = -1;
			return posicionaFicha(tablero, intJugador, arrPos);
		} else {
			System.out.println("Esa ficha no es tuya (" + liIdioma.get(3) + ")");
			return false;
		}
	}

	// Posiciona una ficha
	public static boolean posicionaFicha(int[][] tablero, int intJugador, int[] arrPos) {
		Scanner scn = new Scanner(System.in);
		int intNX, intNY;
		System.out.println("¿Donde quieres poner la ficha? (" + liIdioma.get(4) + ")");
		intNX = introduceNumero('X');
		intNY = introduceNumero('Y');

		if (tablero[intNX][intNY] != -1) {
			System.out.println("Esa posicion esta ocupada (" + liIdioma.get(5) + ")");
			return false;
		} else {
			tablero[intNX][intNY] = intJugador;
			System.out.println("Ficha colocada (" + liIdioma.get(6) + ")");
		}

		if (arrPos != null)
			guardarBBDD(intJugador, objFecha.toString(), intPartida, intTurno, arrPos[0], arrPos[1], intNX, intNY);
		else
			guardarBBDD(intJugador, objFecha.toString(), intPartida, intTurno, -1, -1, intNX, intNY);

		return true;
	}

	// Introduce una de las coordenadas del tablero
	public static int introduceNumero(char charPosicion) {
		int intNumero = -1;
		Scanner scn = new Scanner(System.in);

		while (intNumero < 0 || intNumero > 2) {
			System.out.println("Posicion (" + liIdioma.get(7) + ")" + charPosicion + ": ");
			intNumero = scn.nextInt();
			if (intNumero < 0 || intNumero > 2)
				System.out.println("Posicion (" + liIdioma.get(7) + ")" + charPosicion + " incorrecta("
						+ liIdioma.get(8) + ") 0-1-2");
		}
		return intNumero;
	}

	// Selecciona el idioma para el juego
	public static void traducirJuego() {
		Scanner scn = new Scanner(System.in);
		int intSeleccion;

		System.out.println("Selecciona idoma: 1:Español\t2:Ingles\t3:Frances\t4:Aleman");
		intSeleccion = scn.nextInt();

		switch (intSeleccion) {
		case 2:
			traducir("juegoTraduccion.txt", "Ingles");
			break;
		case 3:
			traducir("juegoTraduccion.txt", "Frances");
			break;
		case 4:
			traducir("juegoTraduccion.txt", "Aleman");
			break;
		default:
			traducir("juegoTraduccion.txt", "Espanol");
		}
	}

	// Con el idioma seleccionado, lee el archivo y cambia el texto del juego
	static void traducir(String strFicheroTraducir, String strIdioma) {
		List<String> liTraducciones = new ArrayList<String>();
		List<String> liTraduccion = new ArrayList<String>();

		try {
			BufferedReader br = new BufferedReader(new FileReader(strFicheroTraducir));
			String strLinea = "";

			while (strLinea != null) {
				strLinea = br.readLine();
				if (strLinea != null)
					liTraducciones.add(strLinea);
			}
			br.close();

		} catch (IOException e) {
			e.printStackTrace();
		}

		try {
			switch (strIdioma) {
			case "Espanol":
				liIdioma = seleccionarIdioma(liTraducciones, 0);
				break;
			case "Ingles":
				liIdioma = seleccionarIdioma(liTraducciones, 1);
				break;
			case "Frances":
				liIdioma = seleccionarIdioma(liTraducciones, 2);
				break;
			case "Aleman":
				liIdioma = seleccionarIdioma(liTraducciones, 3);
				break;
			}
		} catch (Exception e) {
			System.out.println("Error al encontrar fichero de traduccion");
		}

		TreeMap<String, String> treIdioma = new TreeMap<>();
		treIdioma.put(strFicheroTraducir, strIdioma);
	}

	// Filtra el idioma seleccionado de la lista
	static List<String> seleccionarIdioma(List<String> liTraducciones, int intIdioma) {
		List<String> liAux = new ArrayList<String>();
		for (String strLinea : liTraducciones) {
			String[] strAux = strLinea.split(";");
			liAux.add(strAux[intIdioma]);
		}
		return liAux;
	}

	/**
	 * Guarda cada jugada hecha
	 * 
	 * @param intJugador   Jugador de la partida
	 * @param strFecha     Fecha de la partida
	 * @param intPartida   Numero de partida jugada
	 * @param intNumJugada Numero del turno en que se jugo
	 * @param alApos       Posiciones donde se (cambio y) puso la ficha
	 */
	static void guardarBBDD(int intJugador, String strFecha, int intPartida, int intNumJugada, int intPX, int intPY,
			int intFPX, int intFPY) {
		Connection conexion = null;
		int intAux = 0;
		boolean blnInsertar = false;
		Scanner scnLeer = new Scanner(System.in);

		try {
			conexion = DriverManager.getConnection("jdbc:mysql://localhost:3306/java", "java", "clave");

			Statement statement = conexion.createStatement();

			if (intPX != -1 && intPY != -1)
				statement.executeUpdate("inser into raya3 values (Jugador" + intJugador + "," + strFecha + "," + intPartida
						+ "," + intNumJugada + "," + intPX + "," + intPY + "," + intFPX + "," + intFPY);
			else
				statement.executeUpdate("inser into raya3 values (Jugador" + intJugador + "," + strFecha + "," + intPartida
						+ "," + intNumJugada + "," + "null" + "," + "null" + "," + intFPX + "," + intFPY);

		} catch (SQLException e) {
			System.out.println("Error al conectar");
			System.out.println(e);
		}
	}
}
