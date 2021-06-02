package tema9;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.StringTokenizer;

/****************************
 * La clase java.util.StringTokenizer sirve para separar una cadena de caracteres en una serie de elementos o tokens.
 * Los delimitadores por defecto son: espacio en blanco, \t, \n, \r,  \f
 * hasMoreTokens() devuelve true si hay m�s tokens en la cadena.
 * nextToken() devuelve un String con el siguiente token.  excepci�n NoSuchElementException si no hay m�s
 * countTokens() cantidad de tokens que aun quedan por extraer
 * 
String s = "blanco, rojo, verde y azul";
StringTokenizer st = new StringTokenizer(s);                                                                      
while (st.hasMoreTokens())                                                                                        
       System.out.println(st.nextToken());
 * @author elkin
 *
 */
public class EjemploFichero9 {

	public static void main(String[] args){
		Double rlnSuma=0.0; //suma de los n�meros
		int intCont=0; //n�mero de valores leidos
		try {
			BufferedReader br = new BufferedReader(new FileReader("valoresToken.txt"));
			String strLinea = null; //linea leida del fichero
			
			do {
					strLinea = br.readLine();
					if (strLinea!=null) {
						StringTokenizer stNumeros = new StringTokenizer(strLinea);                                                                      
						while (stNumeros.hasMoreTokens()) {                                                                                       
							rlnSuma+=Double.parseDouble(stNumeros.nextToken());
						       intCont++;
						}
					}
			}while (strLinea!=null);
		} catch (IOException e) {System.out.println("Problema en la E/S");}
		if(intCont==0)
			System.out.println("No se ha podido leer ning�n n�mero");
		else
			System.out.println("La media es: " + (rlnSuma/intCont));

	}

}
