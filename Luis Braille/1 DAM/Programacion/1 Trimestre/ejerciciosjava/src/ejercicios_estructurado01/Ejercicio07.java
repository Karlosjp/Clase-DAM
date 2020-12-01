package ejercicios_estructurado01;


import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Carlos Jaquez
 */
public class Ejercicio07 {
    public static void main(String[] args) throws IOException {
        BufferedReader bufLectura = new BufferedReader(new InputStreamReader(System.in));
        int numero, contador = 0;
        boolean continuar = true;
        
        System.out.println("Introduce primer numero (-1 para terminar)");
        numero = Integer.parseInt(bufLectura.readLine());
        if(numero > 0){
            do {
                contador ++;
                System.out.println("Introduce numero (-1 para terminar)");
                int aux = Integer.parseInt(bufLectura.readLine());
                if(aux < 0)
                    continuar = false;
                else            
                    numero += aux;
            }while (continuar);
        
        System.out.println("La media de los numeros introdocidos es: " + numero / contador);
        }
    }
}
