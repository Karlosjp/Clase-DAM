import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Ejercicio2 {
    public static void main(String[] args) throws IOException {
    	String strLeido; 
    	int intNumero1=0,intNumero2=0;
    	BufferedReader bufLectura = new BufferedReader(new InputStreamReader(System.in));
    	
    	while(intNumero1==intNumero2) {
	    	System.out.println("Inserta el primer n�mero: ");
	    	intNumero1 = Integer.parseInt(bufLectura.readLine());
	    	System.out.println("Inserta el segundo n�mero: ");
	    	intNumero2 = Integer.parseInt(bufLectura.readLine());
    	}
    	
    	if (intNumero1 > intNumero2) 
	    	System.out.println("Resultado: El n�mero mayor es: " + intNumero1);
    	else
	    	System.out.println("Resultado: El n�mero mayor es: " + intNumero2);
    }
}