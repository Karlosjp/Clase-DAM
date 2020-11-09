
import java.io.IOException;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Carlos Jaquez
 */
public class Ejercicio11 {
    public static void main(String[] args) throws IOException {
        
        for (int i = 1; i <= 10; i++) 
            for (int j = 0; j <= 10; j++) 
                System.out.println( i +" x " + j + " = " + i*j);
    }
}
