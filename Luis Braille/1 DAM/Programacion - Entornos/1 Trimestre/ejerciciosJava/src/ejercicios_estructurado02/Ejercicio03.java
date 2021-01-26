package ejercicios_estructurado02;

import java.io.IOException;

public class Ejercicio03 {
	public static void main(String[] args) throws IOException {
		long totalMilisegundos, segundos, minutos, horas, dias;
		
		totalMilisegundos = System.currentTimeMillis();
		segundos = totalMilisegundos / 1000;
		minutos = segundos / 60;
		horas = minutos / 60;
		dias = horas / 24;
		
		
		System.out.println("Total milisegundos: " + totalMilisegundos);
		System.out.println("Total segundos: " + segundos);
		System.out.println("Total minutos: " + minutos);
		System.out.println("Total horas: " + horas);
		System.out.println("Total dias: " + dias);
		
		System.out.println("La hora del sistema es: " + horas % 24 + ":" + minutos % 60 + ":" + segundos % 60 + " GMT");
	}
}
