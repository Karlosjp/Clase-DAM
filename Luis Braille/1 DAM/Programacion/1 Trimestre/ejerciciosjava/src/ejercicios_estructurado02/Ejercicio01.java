package ejercicios_estructurado02;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Ejercicio01 {
	public static void main(String[] args) throws IOException {
		BufferedReader bufLectura = new BufferedReader(new InputStreamReader(System.in));
		double millas; 
		
		System.out.println("Introduce millas");
		millas = Integer.parseInt(bufLectura.readLine());
		
		System.out.println("El cambio a KM es: " + millas * 1.6);
	}
}
