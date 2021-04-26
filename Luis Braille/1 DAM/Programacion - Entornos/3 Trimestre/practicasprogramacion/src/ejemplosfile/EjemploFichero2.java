package ejemplosfile;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

/**
 * Leo del fichero java.txt y dejo el contenido en destino.txt
 * si me lo indica el usuario
 *
 */
class EjemploFichero2 {
  public static void main(String[] args) {
    char chrRespuesta;
	Scanner scnLee = new Scanner(System.in);
    
    try {  
      BufferedReader br = new BufferedReader(new FileReader("java.txt"));
      BufferedWriter bw = new BufferedWriter(new FileWriter("destino.txt"));

      String strLinea = "";
      
      while (strLinea != null) {
        strLinea = br.readLine();
        if(strLinea!=null) {
        	System.out.println("Se ha leido " + strLinea + " Deseas insertar esta línea");
        	chrRespuesta = scnLee.nextLine().charAt(0);
        	while(chrRespuesta!='s' && chrRespuesta!='n') {
        		System.out.println("Indique una opción válida (s,n)");
        		chrRespuesta = scnLee.nextLine().charAt(0);
        	}
        	if(chrRespuesta=='s')
        		 bw.write(strLinea + "\r\n");
        }
      } 
    
      br.close();
      bw.close();
    } catch (FileNotFoundException fnfe) { // quÃ© hacer si no se encuentra el fichero
 
      System.out.println("No se encuentra el fichero java.txt");
 
    } catch (IOException ioe) { // quÃ© hacer si hay un error en la lectura del fichero
 
      System.out.println("No se puede leer el fichero java.txt");
 
    }
  }
}
