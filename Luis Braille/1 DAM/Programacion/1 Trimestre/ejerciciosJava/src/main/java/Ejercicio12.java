
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
public class Ejercicio12 {
    public static void main(String[] args) throws IOException {
        BufferedReader bufLectura = new BufferedReader(new InputStreamReader(System.in));
        int numero, contador = 0;

        System.out.println("Introduce un numero:");
        numero = Integer.parseInt(bufLectura.readLine());
        
        for (int i = numero - 1; i > 2; i--) 
            if(primo(i))
                contador++;

        System.out.println("Hay " + contador + " numeros primos desde el 1 al " + numero);        
    }
    
    static boolean primo (int num){
        boolean primo = true;
        int contador = 2;
        
        while (primo && contador != num) {            
            if(num % contador == 0)
                primo = false;
            contador++;         
        }
        
        return primo;
    }
}
