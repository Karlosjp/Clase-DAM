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
public class Ejercicio02 {
     public static void main(String[] args) throws IOException {
        int num = 0, inverso = 0, resto = 0;
        BufferedReader bufLectura = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Escribe un numero entre 0 y 9.999: ");
    	num = Integer.parseInt(bufLectura.readLine());

        if(num > 0 && num < 9999){
            while(num != 0){
                resto = num % 10; 
                inverso = inverso * 10 + resto;
                num /= 10;
            }
            System.out.println("El resultado es  " + inverso);
        }
        else
            System.out.println("Numero no valido  ");
    }
}
