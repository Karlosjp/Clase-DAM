
public class Ejercicio4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		// Recorrer un array de enteros y dar la cantidad total de nº pares
		int contador = 0;
		int [] enteros = {4, 5, 7, 10, 14, 9, 17, 2, 1, 28};
		//           i =  0  1  2   3   4  5   6  7  8
		
		for (int i=0; i<enteros.length; i++) {
			
			//int numero = enteros[i]; //4
			
			if (enteros[i]%2 == 0) {
				contador++;
			}
			
		}
		
		System.out.println(contador);

	}

}
