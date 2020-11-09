package ejercicios_estructurado;


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
public class Ejercicio06 {
    public static void main(String[] args) throws IOException {
        BufferedReader bufLectura = new BufferedReader(new InputStreamReader(System.in));
        int numero;
        boolean continuar = true;

        System.out.println("Escribe un numero: ");
        numero = Integer.parseInt(bufLectura.readLine());

        while (continuar) {        
            System.out.println("Adivina el numero");
            int intento = Integer.parseInt(bufLectura.readLine());
            int aux = intento - numero;

            if(aux == 0){
                continuar = false;
                System.out.println("Numero correcto");
            }else if(aux > 100)
                System.out.println("Frio artico, el numero es menor");
            else if(aux > 50)
                System.out.println("Frio, el numero es menor");
            else if (aux > 0)
                System.out.println("caliente, el numero es menor");
            else if (aux < -100)
                System.out.println("Frio artico, el numero es mayor");
            else if(aux < -50)
                System.out.println("Frio, el numero es mayor");
            else
                System.out.println("caliente, el numero es mayor");
        }
    }
}
