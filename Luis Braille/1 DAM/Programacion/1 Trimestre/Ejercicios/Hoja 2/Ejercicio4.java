import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Ejercicio4 {
    public static void main(String[] args) throws IOException {
        int dia = 0, mes = 0, anho = 0;
        BufferedReader bufLectura = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Escribe anho: ");
    	anho = Integer.parseInt(bufLectura.readLine());
        System.out.println("Escribe mes: ");
    	mes = Integer.parseInt(bufLectura.readLine());
        System.out.println("Escribe dia: ");
    	dia = Integer.parseInt(bufLectura.readLine());

        System.out.println("Fecha: Dia " + dia + " Mes " + mes + " Anho " + anho);

        dia++;
        
        if (mes == 12 && dia > 31){
            mes = 1;
            anho++;
            dia = 1;
        }
        else if(mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10){
            if(dia > 31){
                mes++;
                dia = 1;
            }
        } 
        else if((mes == 2 && dia > 28) || dia > 30){
            mes++;
            dia = 1;
        }

        System.out.println("Fecha siguiente: Dia " + dia + " Mes " + mes + " Ahno " + anho);
    }
}