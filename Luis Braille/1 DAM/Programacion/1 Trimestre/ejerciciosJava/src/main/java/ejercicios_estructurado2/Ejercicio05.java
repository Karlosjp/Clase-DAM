package ejercicios_estructurado2;

import java.io.IOException;

public class Ejercicio05 {
	public static void main(String[] args) throws IOException {
		int puntosA[][] = {
				{0, 0},
				{1, 4},
				{2, 7},
				{3, 9},
				{4, 11}
		},
			puntosB[][] = {
				{2, 1},
				{4, 2},
				{6, 3},
				{10, 5},
				{12, 7}
		};
		
		for (int i = 0; i < puntosA.length; i++) {
			double medioA = puntosA[i][0] + puntosA[i][1]; 
			double medioB = puntosB[i][0] + puntosB[i][1]; 
			System.out.println("(" + medioA + "," + medioB);
		}
	}
}
