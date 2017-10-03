
public class Ejercicio5 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		// Recorrer un array de enteros y sacar TRUE si existe el 1
		// Sacar FALSE si no existe el numero 1
		
		boolean encontrado = false;
		
		int [] enteros = {4, 5, 7, 14, 1, 9, 17, 2, 28,1};
		//           i =  0  1  2  3   4  5   6  7  8  9
		
		for (int i=0; i<enteros.length && encontrado==false; i++) {
			
			//int numero = enteros[i]; //4
			
			if (enteros[i] == 1) {
				encontrado = true;
				System.out.println(encontrado);
				
			}
			
		}
		
		if (encontrado== false) {
			System.out.println("No se ha encontrado ningun 1");
		}
		
		

	}

}
