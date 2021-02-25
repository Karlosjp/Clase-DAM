package tema5.ejercicio1;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Persona objPersonas[] = new Persona[5];
		int intContinuar = 0, intTotal = 0;

		Scanner snc = new Scanner(System.in);

		do {
			System.out.println("¿Que quieres introducir?");
			System.out.println("1. Persona");
			System.out.println("2. Autonomo");
			System.out.println("3. Trabajador");
			System.out.println("4. Parado");
			System.out.println("5. Estudiante");

			objPersonas[intTotal++] = crearNuevo(snc.nextInt());

			System.out.println("¿Terminar? Si = 1, No = 0");
			intContinuar = snc.nextInt();

		} while (intContinuar == 0 | intTotal == 5);

		for (Persona persona : objPersonas) {
			persona.imprimir();
		}

	}

	private static Persona crearNuevo(int intIndice) {
		String strDatos[] = solicitarDatos(intIndice);
		SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
		Date fechaNacim = new Date();
		
		try {
			fechaNacim = sdf.parse(strDatos[3]);
		} catch (ParseException e) {
			// TODO Auto-generated catch block
			System.err.println("Formato de fecha incorrecto");
			e.printStackTrace();
		}

		switch (intIndice) {
		case 1:
			return new Persona(strDatos[0], strDatos[1], strDatos[2], fechaNacim);
		case 2:
			return new Autonomo(strDatos[0], strDatos[1], strDatos[2], fechaNacim, strDatos[4]);
		case 3:
			return new Trabajador(strDatos[0], strDatos[1], strDatos[2], fechaNacim, strDatos[4]);
		case 4:
			return new Parado(strDatos[0], strDatos[1], strDatos[2], fechaNacim, strDatos[3]);
		case 5:
			return new Estudiante(strDatos[0], strDatos[1], strDatos[2], fechaNacim, strDatos[4]);
		}

		return null;
	}

	private static String[] solicitarDatos(int intIndice) {
		Scanner snc = new Scanner(System.in);
		String strDatos[] = new String[5];

		System.out.println("*- Escribe su nombre");
		strDatos[0] = snc.nextLine();
		System.out.println("*- Escribe su sexo");
		strDatos[1] = snc.nextLine();
		System.out.println("*- Escribe su direccion");
		strDatos[2] = snc.nextLine();
		System.out.println("*- Escribe su fecha de nacimiento yyyy-MM-dd (Ej. 1990-09-15)");
		strDatos[3] = snc.nextLine();

		switch (intIndice) {
		case 2:
			System.out.println("*- Escribe su el nombre de la empresa");
			strDatos[4] = snc.nextLine();
			break;
		case 3:
			System.out.println("*- Escribe su puesto");
			strDatos[4] = snc.nextLine();
			break;
		case 4:
			System.out.println("*- Escribe meses de duracion");
			strDatos[4] = snc.nextLine();
			break;
		case 5:
			System.out.println("*- Escribe curso actual");
			strDatos[4] = snc.nextLine();
			break;
		default:
			strDatos[4] = "";
		}

		return strDatos;
	}

}
