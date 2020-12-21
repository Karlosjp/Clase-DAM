package asterisco2;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		double rlnValor=0;
		double rlnPaga=0;
		String strSalir;
		Scanner scnLeer = new Scanner(System.in);

		do {
			System.out.println("Precio del siguiente artículo");
			rlnValor += scnLeer.nextDouble();
			System.out.println("Deseas salir (s,n)?");
			strSalir = scnLeer.next();
		}while(strSalir.equals("s"));
		
		System.out.println("Total a pagar " + rlnValor);
		rlnPaga = scnLeer.nextDouble();
		
		rlnPaga-=rlnValor;//calculo de la vuelta
		System.out.println("Total a devolver " + rlnPaga);
		
		if(rlnPaga>=20) {
			System.out.println("Billetes de 20€: " + (int)rlnPaga/20);
			rlnPaga%=20;
		}
		if(rlnPaga>=10) {
			System.out.println("Billetes de 10€: " + (int)rlnPaga/10);
			rlnPaga%=10;
		}
		if(rlnPaga>=5) {
			System.out.println("Billetes de 5€: " + (int)rlnPaga/5);
			rlnPaga%=5;
		}
		if(rlnPaga>=2) {
			System.out.println("Monedas de 2€: " + (int)rlnPaga/2);
			rlnPaga%=2;
		}
		if(rlnPaga>=1) {
			System.out.println("Monedas de 1€: " + (int)rlnPaga);
			rlnPaga-=1;
		}

		if(rlnPaga>0) 
			System.out.println("Monedas de 0,5€: 1");
	}

}
