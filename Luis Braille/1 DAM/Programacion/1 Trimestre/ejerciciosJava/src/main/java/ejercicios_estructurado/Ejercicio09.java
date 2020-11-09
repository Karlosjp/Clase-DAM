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
public class Ejercicio09 {
    public static void main(String[] args) throws IOException {
        Alumno alumnos[] = new Alumno[5];
        
        alumnos[0] = new Alumno(20, 180);
        alumnos[1] = new Alumno(25, 170);
        alumnos[2] = new Alumno(18, 170);
        alumnos[3] = new Alumno(17, 190);
        alumnos[4] = new Alumno(28, 160);

        int eMedia = 0,eCont = 0, aMedia = 0, aCont = 0;
        for (Alumno alumno : alumnos) {
            int eAux = alumno.getEdad();
            int aAux = alumno.getAltura();
            
            if(eAux > 18){
                eMedia += eAux;
                eCont++;
            }
            if(aAux > 175){
                aMedia += aAux;
                aCont++;
            }
        }
        
        System.out.println("Hay una edad media de " + eMedia / eCont 
                + " en alumnos mayores de 18 y una altura media de " 
                + aMedia / aCont + " alumnos que miden mas de 1.75.");
    }
}

class Alumno{
    int edad, altura;
    
    public Alumno(int edad, int altura){
        this.edad = edad;
        this.altura = altura;
    }

    public int getAltura() {
        return altura;
    }

    public int getEdad() {
        return edad;
    }
}
