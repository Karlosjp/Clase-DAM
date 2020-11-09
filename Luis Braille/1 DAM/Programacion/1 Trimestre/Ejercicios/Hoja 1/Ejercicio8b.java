import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Ejercicio8b {
    public static void main(String[] args) throws IOException {
        BufferedReader bufLectura = new BufferedReader(new InputStreamReader(System.in));
        int total = 0, suma = 0;

        System.out.println("¿Cuantos numeros impares quieres sumar?: ");
        total = Integer.parseInt(bufLectura.readLine());

        for(int i = 1, c= 0; c < total ; c ++, i++)
            if(i % 2 == 0)
                suma += i;

        System.out.println("Numero: " + suma);
    }
}