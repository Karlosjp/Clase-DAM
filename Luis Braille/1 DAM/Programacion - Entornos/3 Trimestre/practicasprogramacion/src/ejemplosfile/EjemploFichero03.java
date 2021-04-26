package ejemplosfile;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

/**
 * Ejemplo de uso de la clase File
 * Mezcla de dos ficheros
 *
 */
class EjemploFichero03 {
  public static void main(String[] args) {
    
    try {
      BufferedReader br1 = new BufferedReader(new FileReader("fichero1.txt"));
      BufferedReader br2 = new BufferedReader(new FileReader("fichero2.txt"));
      BufferedWriter bw = new BufferedWriter(new FileWriter("mezcla.txt"));
    
      String StrLinea1 = "";
      String strLinea2 = "";
      
      while ( (StrLinea1 != null) || (strLinea2 != null) ) {
        StrLinea1 = br1.readLine();
        strLinea2 = br2.readLine();
        if (StrLinea1 != null) {
          bw.write(StrLinea1 + "\n");
        }
        if (strLinea2 != null) {
          bw.write(strLinea2 + "\n");
        }
      } 
    
      br1.close();
      br2.close();
      bw.close();
    
      System.out.println("Archivo mezcla.txt creado satisfactoriamente.");

    } catch (IOException ioe) {
      System.out.println("Se ha producido un error de lectura/escritura");
      System.err.println(ioe.getMessage());
    }
  }
}
