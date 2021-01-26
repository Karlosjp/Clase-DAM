package ejercicio02;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		// Utilizar el constructor por defecto
		Contador contador1 = new Contador();

		int n;
		System.out.println("Introduce valor para inicializar el contador: ");
		n = sc.nextInt();

		// asignar un valor al contador
		contador1.setIntCont(n);
		// incrementar el contador
		contador1.incrementa();
		// mostrar el valor actual
		System.out.println(contador1.getIntCont());

		contador1.incrementa();
		contador1.incrementa();

		// mostrar el valor actual
		System.out.println(contador1.getIntCont());

		// restar 1 al valor del contador
		contador1.decrementa();

		// mostrar el valor actual
		System.out.println(contador1.getIntCont());

		// crear un nuevo objeto Contador con valor inicial 10
		Contador contador2 = new Contador(10);

		// incrementar y decrementar el contador2 y mostrar su valor
		contador2.incrementa();
		System.out.println(contador2.getIntCont());
		contador2.decrementa();
		System.out.println(contador2.getIntCont());

		// crear un objeto Contador utilizando el constructor copia
		// se crea el objeto contador3 como copia de contador2
		Contador contador3 = new Contador(contador2);

		// mostrar el valor de contador3
		System.out.println(contador3.getIntCont());
	}

}
