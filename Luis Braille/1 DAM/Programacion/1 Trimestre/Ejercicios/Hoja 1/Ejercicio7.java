import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Ejercicio7 {
    public static void main(String[] args) throws IOException {

        for(int i = 2, c= 0; c < 100 ; c ++, i+=2)
            System.out.println("Numero: " + i);
    }
}