package ajustar;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		double rlnTotal=0;
		double rlnPaga;
		
		int intRespuesta;
		Scanner scnLeer = new Scanner(System.in);

		do {
			System.out.println("Valor del artículo ");
			rlnTotal += scnLeer.nextDouble();
			System.out.println("Si deseas meter mas artículos pulsa 0");
			intRespuesta = scnLeer.nextInt();
		}while(intRespuesta==0 && rlnTotal<50);
		
		do {
			System.out.println("Total a pagar: " + rlnTotal);
			System.out.println("Introduce el dinero ");
			rlnPaga = scnLeer.nextDouble();
		}while(rlnPaga < rlnTotal);
		
		rlnTotal = rlnPaga - rlnTotal;//calculo la vuelta
		System.out.println("Vuelta de: " + rlnTotal);
		if(rlnTotal>=20) {
			System.out.println("Billetes de 20€ " + (int)rlnTotal/20);
			rlnTotal %= 20;
		}
		if(rlnTotal>=10) {
			System.out.println("Billetes de 10€ " + (int)rlnTotal/10);
			rlnTotal %= 10;
		}
		if(rlnTotal>=5) {
			System.out.println("Billetes de 5€ " + (int)rlnTotal/5);
			rlnTotal %= 5;
		}
		if(rlnTotal>=2) {
			System.out.println("Monedas de 2€ " + (int)rlnTotal/2);
			rlnTotal %= 2;
		}
		if(rlnTotal>=1) {
			System.out.println("Monedas de 1€ " + (int)rlnTotal/1);
			rlnTotal -= 1;
		}
		if(rlnTotal>=0.5) {
			System.out.println("Monedas de 50 centimos " + rlnTotal/0.5);
		}
	}

}
