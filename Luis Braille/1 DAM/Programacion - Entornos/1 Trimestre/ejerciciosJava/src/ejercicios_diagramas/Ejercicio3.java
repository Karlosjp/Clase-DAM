import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Ejercicio3 {
    public static void main(String[] args) throws IOException {
    	String strLeido; 
    	int intNumero1=0,intNumero2=0,intNumero3=0;
        BufferedReader bufLectura = new BufferedReader(new InputStreamReader(System.in));

        System.out.println("Inserta el primer numero: ");
        intNumero1 = Integer.parseInt(bufLectura.readLine());
        System.out.println("Inserta el segundo numero: ");
        intNumero2 = Integer.parseInt(bufLectura.readLine());
        System.out.println("Inserta el segundo numero: ");
        intNumero3 = Integer.parseInt(bufLectura.readLine());
    	
        if (intNumero1 < intNumero2) {
            if(intNumero2 < intNumero3){
	    	    System.out.println("Resultado: El numero menor es: " + intNumero1);
	    	    System.out.println("Resultado: El numero mayor es: " + intNumero3);
            }
            else{
                System.out.println("Resultado: El numero menor es: " + intNumero2);

                if(intNumero1 > intNumero3)
                    System.out.println("Resultado: El numero mayor es: " + intNumero3);
                else
                    System.out.println("Resultado: El numero mayor es: " + intNumero1);
            }
        }else {
            if(intNumero1 < intNumero3){
                System.out.println("Resultado: El numero menor es: " + intNumero3);
                System.out.println("Resultado: El numero mayor es: " + intNumero2);
            }else{
                System.out.println("Resultado: El numero menor es: " + intNumero2);

                if(intNumero2 > intNumero3)
                    System.out.println("Resultado: El numero mayor es: " + intNumero3);
                else
                    System.out.println("Resultado: El numero mayor es: " + intNumero1);
            }
        }
    }
}
