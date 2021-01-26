import java.io.BufferedReader;
import java.io.IOException;
import java.util.Scanner;

public class Ejercicio1dos {
    public static void main(String[] args) throws IOException {
    	String strLeido; 
    	int intNumero1,intNumero2;
    	Scanner scnLector = new Scanner(System.in);
    	
    	System.out.printf("%s","Inserta el primer n�mero: ");
    	intNumero1 = scnLector.nextInt();
    	System.out.printf("%s","Inserta el segundo n�mero: ");
    	intNumero2 = scnLector.nextInt();
    	System.out.printf("Resultado: " + (intNumero1 + intNumero2));
    }
}
