package ejercicio.tema8.ejercicio5;

import java.util.ArrayList;
import java.util.Collections;

public class Main {
  public static void main(String[] args) {
    
	  ArrayList<Carta> alCartas = new ArrayList<Carta>();
	    
	    Carta objCarta = new Carta();
	    alCartas.add(objCarta);
	    
	    for (int intCont = 0; intCont < 9; intCont++) {
	      do {
	        objCarta = new Carta();      
	      } while (alCartas.contains(objCarta));//si la carta existe repetir
	      alCartas.add(objCarta);
	    }
	    
	    Collections.sort(alCartas);
	    
	    for (Carta miCarta: alCartas) 
	      System.out.println(miCarta);
  }
}
