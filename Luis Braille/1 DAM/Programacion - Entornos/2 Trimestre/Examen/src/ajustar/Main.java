package ajustar;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);

		int int20 = 0, int10 = 0, int5 = 0, int2 = 0, int1 = 0;
		double dou05 = 0;

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

		int20 = (int) douDevuelta / 20;
		if (int20 > 0)
			douDevuelta -= (20 * int20);

		int10 = (int) douDevuelta / 10;
		if (int10 > 0)
			douDevuelta -= (10 * int10);

		int5 = (int) douDevuelta / 5;
		if (int5 > 0)
			douDevuelta -= (5 * int5);

		int2 = (int) douDevuelta / 2;
		if (int2 > 0)
			douDevuelta -= (2 * int2);

		int1 = (int) douDevuelta / 1;
		if (int1 > 0)
			douDevuelta -= (1 * int1);

		dou05 = douDevuelta / 0.5;

		System.out.println("El total es " + douTotal + ", a devolver 20€ = " + int20 + ", 10€ = " + int10 + ", 5€ = "
				+ int5 + ", 2€ = " + int2 + ", 1€ = " + int1 + ", 0.5€ = " + dou05);
	}

}
