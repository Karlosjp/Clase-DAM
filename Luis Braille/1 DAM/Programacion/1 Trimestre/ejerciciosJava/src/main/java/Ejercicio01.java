
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
public class Ejercicio01 {
        public static void main(String[] args) throws IOException {

        BufferedReader bufLectura = new BufferedReader(new InputStreamReader(System.in));
        System.out.println("Escribe un numero entre 0 y 9.999: ");
        String num = bufLectura.readLine();

        System.out.println("El numero tiene " + num.length() + " digitos");
    }
}
