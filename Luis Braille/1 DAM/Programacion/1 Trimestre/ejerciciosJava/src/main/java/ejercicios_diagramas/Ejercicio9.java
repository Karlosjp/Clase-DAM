import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Ejercicio9 {
    public static void main(String[] args) throws IOException {
        BufferedReader bufLectura = new BufferedReader(new InputStreamReader(System.in));
        int seg = 0, min = 0, hora=0;
        boolean nDia = false;

        while(!nDia){
            System.out.println("Relog: " + hora + " H," + min + " m," + seg + "s");

            if(++seg > 59){
                seg = 0;
                if (++min > 59){
                    min = 0;
                    if(++hora > 23){
                        hora = 0;
                        nDia = true;
                    }
                }
            }
        }
    }
}