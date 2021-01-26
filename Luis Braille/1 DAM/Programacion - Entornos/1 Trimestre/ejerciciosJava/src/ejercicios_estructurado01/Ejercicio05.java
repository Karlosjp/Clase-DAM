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
public class Ejercicio05 {
    public static void main(String[] args) throws IOException {
        BufferedReader bufLectura = new BufferedReader(new InputStreamReader(System.in));
        String nLetra = "";
        int resto = 0, num = 0;

        System.out.println("Escribe numero: ");
        num = Integer.parseInt(bufLectura.readLine());
        
        if(num >= 16 && num % 10 != 0){
            resto = num % 10;
            nLetra = letras(resto);
            num /= 10;
            resto = num % 10;
            nLetra = letras(resto*10) + " y " + nLetra;
        }
        else{
            nLetra = letras(num);
        }            
        
        System.out.println(nLetra);
    }
    
    static String letras(int num){
        String nLetra;
        
        switch(num){
            case 1:
                nLetra = "uno";
                break;                
            case 2:
                nLetra = "dos";
                break;
            case 3:
                nLetra = "tres";
                break;
            case 4:
                nLetra = "cuatro";
                break;
            case 5:
                nLetra = "cinco";
                break;
            case 6:
                nLetra = "seis";
                break;
            case 7:
                nLetra = "siete";
                break;
            case 8:
                nLetra = "ocho";
                break;
            case 9:
                nLetra = "nueve";
                break;
            case 10:
                nLetra = "diez";
                break;
            case 11:
                nLetra = "once";
                break;
            case 12:
                nLetra = "doce";
                break;
            case 13:
                nLetra = "trece";
                break;
            case 14:
                nLetra = "catorce";
                break;
            case 15:
                nLetra = "quince";
                break;
            case 20:
                nLetra = "veinte";
                break;
            case 30:
                nLetra = "treinta";
                break;
            case 40:
                nLetra = "cuarenta";
                break;
            case 50:
                nLetra = "cincuenta";
                break;
            case 60:
                nLetra = "secenta";
                break;
            case 70:
                nLetra = "setenta";
                break;
            case 80:
                nLetra = "ochenta";
                break;
            case 90:
                nLetra = "nocenta";
                break;
            default:
                nLetra = "";
            }
         return nLetra;
    }
}
