import java.util.Scanner;

public class Ejercicio2 {

	private static Scanner entrada;

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		int opcion = 0;
		int n1 = 0, n2 = 0;
		int resultado = 0;

		entrada = new Scanner(System.in);

		do {

			System.out.println("MENU CALCULADORA:");
			System.out.println("===========================");
			System.out.println("1. SUMAR DOS NUMEROS");
			System.out.println("2. RESTAR DOS NUMEROS");
			System.out.println("3. MULTIPLICAR DOS NUMEROS");
			System.out.println("4. DIVIDIR DOS NUMEROS");
			System.out.println("5. SALIR");
			System.out.print("INTRODUZCA OPCION: ");

			opcion = entrada.nextInt();

			if (opcion != 1 && opcion != 2 && opcion != 3 && opcion != 4 && opcion != 5) {
				System.out.println("Opcion no valida");
			}

			else {

				n1 = entrada.nextInt();
				n2 = entrada.nextInt();

				if (opcion == 1) {
					resultado = sumar(n1, n2);
					System.out.println("El resultado es: " + resultado);
				}

				if (opcion == 2) {
					resultado = restar(n1, n2);
					System.out.println("El resultado es: " + resultado);
				}

				if (opcion == 3) {
					resultado = multiplicar(n1, n2);
					System.out.println("El resultado es: " + resultado);
				}

				if (opcion == 4) {
					resultado = dividir(n1, n2);
					System.out.println("El resultado es: " + resultado);
				}

				
			}

		} while (opcion != 5);

	}

	private static int dividir(int n1, int n2) {
		// TODO Auto-generated method stub
		return n1 / n2;
	}

	private static int multiplicar(int n1, int n2) {
		// TODO Auto-generated method stub
		return n1 * n2;
	}

	private static int restar(int n1, int n2) {
		// TODO Auto-generated method stub
		return n1 - n2;
	}

	private static int sumar(int n1, int n2) {
		// TODO Auto-generated method stub
		return n1 + n2;
	}

}
