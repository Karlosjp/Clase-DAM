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
public class Ejercicio10 {
    public static void main(String[] args) throws IOException {
        BufferedReader bufLectura = new BufferedReader(new InputStreamReader(System.in));
        boolean continuar = true;
        int numero = 0;
        
        do{
            System.out.println("Escribe un numero del 0 al 10:");
            numero = Integer.parseInt(bufLectura.readLine());
            
            if (numero >= 0 && numero <= 10)
                continuar = false;
            
        }while (continuar);             
        
        for (int i = 0; i <= 10; i++) 
            System.out.println( numero +" x " + i + " = " + numero*i);
    }
}
