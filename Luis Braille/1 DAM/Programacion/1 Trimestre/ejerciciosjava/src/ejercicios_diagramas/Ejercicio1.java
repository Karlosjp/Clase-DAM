import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Ejercicio1 {
    public static void main(String[] args) throws IOException {
    	String strLeido; 
    	int intNumero1,intNumero2;
    	BufferedReader bufLectura = new BufferedReader(new InputStreamReader(System.in));

    	System.out.println("Inserta el primer n�mero: ");
    	intNumero1 = Integer.parseInt(bufLectura.readLine());
    	System.out.println("Inserta el segundo n�mero: ");
    	intNumero2 = Integer.parseInt(bufLectura.readLine());
    	System.out.println("Resultado: " + (intNumero1 + intNumero2));
    }
}
