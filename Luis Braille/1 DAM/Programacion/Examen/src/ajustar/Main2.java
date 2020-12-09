package ajustar;

import java.util.ArrayList;
import java.util.Scanner;

public class Main2 {

	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);

		ArrayList<String> devuelta = new ArrayList();

		int[] billetes = { 20, 10, 5, 2, 1 };
		int int05 = 0;

		boolean booContinuar = true;
		int intContinuar = 1;
		double douTotal = 0, douDevuelta = 0;

		do {

			System.out.println("Introduce precio del articulo: ");
			double douPrecio = scn.nextDouble();

			double aux = douTotal + douPrecio;

			if (aux >= 50) {
				System.out.println("El total de la compra sobrepasa 50€");
			} else
				douTotal = aux;

			System.out.println("Desea continuar : Si = 1, No = 0");
			intContinuar = scn.nextInt();

			if (intContinuar != 1)
				booContinuar = false;

		} while (booContinuar);

		do {
			System.out.println("El total es: " + douTotal + " Introduce pago del cliente: ");
			double aux = scn.nextDouble();

			douDevuelta = aux - douTotal;

		} while (douDevuelta < 0);

		for (int i = 0; i < billetes.length; i++) {
			int aux = (int) (douDevuelta / billetes[i]);
			if (aux > 0) {
				devuelta.add(aux + " de " + billetes[i]);
				douDevuelta -= billetes[i] * aux;
			}
		}
		
		if(douDevuelta > 0) {
			int05 = (int) (douDevuelta / 0.5);
			devuelta.add(int05 + " de 0.5€");
		}
		
		for (String s : devuelta) {
			System.out.println(s);
		}
	}

}
