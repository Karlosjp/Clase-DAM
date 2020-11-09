import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Ejercicio11 {
    public static void main(String[] args) throws IOException {
        BufferedReader bufLectura = new BufferedReader(new InputStreamReader(System.in));
        boolean continuar = true;
        int nPar = 0, nImpar = 1;

        while(continuar){

            System.out.println("Insertar numero:");
            int num = Integer.parseInt(bufLectura.readLine());

            if(num % 2 == 0)
                nPar += num;
            else
                nImpar *= num;

            System.out.println("Desea continuar? N:-1");
            int cont = Integer.parseInt(bufLectura.readLine());

            System.out.println("La suma de los pares es: " + nPar);
            System.out.println("El producto de los impares es: " + nImpar);
            
            if(cont == -1)
                continuar = false;
        }
    }
}