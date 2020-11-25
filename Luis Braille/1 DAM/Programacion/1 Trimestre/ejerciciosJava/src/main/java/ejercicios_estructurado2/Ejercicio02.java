package ejercicios_estructurado2;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Ejercicio02 {
	public static void main(String[] args) throws IOException {
		BufferedReader bufLectura = new BufferedReader(new InputStreamReader(System.in));
		int segundos, min = 0, h = 0, dia = 0;
		
		System.out.println("Introduce segundos");
		segundos = Integer.parseInt(bufLectura.readLine());
		
		if(segundos > 59) {
			min = segundos / 60;
			segundos %= 60;
			
			if(min > 59) {
				h = min / 60;
				min %= 60;
				
				if(h > 23) {
					dia = h / 24;
					h %= 24;
				}
			}
		}
		
		System.out.println(dia + " dias " + h + " horas " + min + " min " + segundos + " segundos");
	}
}
