
//Ejercicio 9: Calcula el factorial de un número entero positivo a través de la recursividad.


public class Ejercicio9 {

	static int factorial(int n){
		if(n == 1)
			return 1;
		return n*factorial(n-1);
		
	}
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		int resultado = factorial(5);
		System.out.println("El factorial de 5 es: "+resultado);
		
	}

}
