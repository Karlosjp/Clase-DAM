package ejercicios_estructurado02;

import java.io.IOException;
import java.util.Scanner;

public class Ejercicio04 {
	public static void main(String[] args) throws IOException {
		Scanner scn = new Scanner(System.in);
		int datos, tipo;
		double b, kb, mb, gb, tb;
		
		System.out.println("Escribe cantidad de datos:");
		datos = scn.nextInt();
		
		System.out.println("Que tipo de dato es?: ");
		System.out.println("0 = byte");
		System.out.println("1 = Kilobyte");
		System.out.println("2 = Megabyte");
		System.out.println("3 = Gigabyte");
		System.out.println("4 = Terabyte");
		tipo = scn.nextInt();
		
		switch (tipo) {
			case 0:
				kb = datos / 1024;
				System.out.println(kb + "kb");
				mb = kb / 1024;
				System.out.println(mb + "mb");
				gb = mb / 1024;
				System.out.println(gb + "gb");
				tb = gb / 1024;
				System.out.println(tb + "tb");
				break;
			case 1:
				mb = datos / 1024;
				System.out.println(mb + "mb");
				gb = mb / 1024;
				System.out.println(gb + "gb");
				tb = gb / 1024;
				System.out.println(tb + "tb");
				break;
			case 2:
				gb = datos / 1024;
				System.out.println(gb + "gb");
				tb = gb / 1024;
				System.out.println(tb + "tb");
				break;
			case 3:
				tb = datos / 1024;
				System.out.println(tb + "tb");
				break;
			case 4:
				System.out.println(datos + "tb");
				break;
		}
				
	}
}
