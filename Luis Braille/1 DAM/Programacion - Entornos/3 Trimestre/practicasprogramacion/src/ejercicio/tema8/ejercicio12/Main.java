package ejercicio.tema8.ejercicio12;

import java.util.ArrayList;
import java.util.Collections;
import java.util.HashMap;

public class Main {
	public static void main(String[] args) {

		ArrayList<Carta> alCartas = new ArrayList<Carta>();
		HashMap<String, String> hmBrisca = new HashMap<String, String>();
		int intPuntuacion = 0;

		hmBrisca.put("as", "11");
		hmBrisca.put("tres", "10");
		hmBrisca.put("sota", "2");
		hmBrisca.put("caballo", "3");
		hmBrisca.put("rey", "4");

		Carta objCarta = new Carta();

		for (int intCont = 0; intCont < 5; intCont++) {
			do {
				objCarta = new Carta();
			} while (alCartas.contains(objCarta));// si la carta existe repetir
			alCartas.add(objCarta);
		}

		Collections.sort(alCartas);

		for (Carta miCarta : alCartas) {
			System.out.println(miCarta);
			if (hmBrisca.get(miCarta.getNumero()) != null)
				intPuntuacion += Integer.parseInt(hmBrisca.get(miCarta.getNumero()));
		}

		System.out.println("Tienes " + intPuntuacion + " puntos");
	}
}
