
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
public class Ejercicio13 {
    public static void main(String[] args) throws IOException {
        BufferedReader bufLectura = new BufferedReader(new InputStreamReader(System.in));
        int elem;
        
        System.out.println("Introduce tamaño n del cuadrado: ");
        elem = Integer.parseInt(bufLectura.readLine());
        
        
        for (int i = 1; i <= elem; i++) {
            for (int j = 1; j <= elem; j++)
                System.out.print("*");
            
            System.out.println("");
        }
    }
}
