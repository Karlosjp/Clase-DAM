package ejercicios_estructurado;


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
    	
        for (int i = 1; i < 10; i+=3) {
        	for (int j = 1; j < 10; j++) {
        		for (int x = i; x < i+3; x++)
        			System.out.print( x +" x " + j + " = " + x*j + "\t");
        	
        		System.out.println("");
        	}
        	
        	System.out.println("");
        }
        	
    }
}



// 1 * 1 = 1   2 * 1 = 2