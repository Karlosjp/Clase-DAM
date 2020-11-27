package ejerciciospoo;

import java.util.ArrayList;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		int option;
		
		System.out.println("Que ejercicio quieres?: 1 (Ejercicio1), 2 (Ejercicio2)");
		option = scn.nextInt();
		
		switch (option) {
		case 1: {
			Ejercicio1();
			break;
		}
		
		case 2: {
			Ejercicio2();
			break;
		}
		default:
			throw new IllegalArgumentException("Unexpected value: " + option);
		}
	}
	
	/* 
	 * Inicio Ejercicio 1
	 */
	private static void Ejercicio1() {
		ArrayList<CuentaCorriente> cuentas = new ArrayList();
		
		cuentas.add(new CuentaCorriente());
		cuentas.add(new CuentaCorriente(1500));
		cuentas.add(new CuentaCorriente(6000));
		
		ImprimeDatosCompletos(cuentas);
		
		cuentas.get(0).ingreso(2000);
		cuentas.get(1).cargo(600);
		cuentas.get(2).ingreso(75);
		cuentas.get(0).cargo(55);
		
		cuentas.get(1).transferencia(cuentas.get(2), 100);
		ImprimeDatosCompletos(cuentas);		
	}
	
	private static void ImprimeDatosCompletos(ArrayList<CuentaCorriente> cuentas){
		for (CuentaCorriente cuentaCorriente : cuentas) {
			System.out.println(cuentaCorriente.datos());
		}
	}
	// Fin de Ejercicio 1
	
	/*
	 * Inicio Ejercicio 2
	 */
	private static void Ejercicio2() {
		Punto p1 = new Punto(4.21, 7.3);
		Punto p2 = new Punto(-2, 1.66);
		Linea l = new Linea(p1, p2);
		
		System.out.println(l.getLinea());
	}
	// Fin ejercicio 2
	
	
}
