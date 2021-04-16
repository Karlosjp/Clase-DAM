package ejercicio.tema8.ejercicio5;
import java.util.Objects;

public class Carta implements Comparable<Carta> {//si no meto comparable no puedo usar sort

	private static String[] strValor = {"as", "dos", "tres", "cuatro", "cinco", "seis", "siete", "sota", "caballo", "rey"};
	private static String[] strPal = {"bastos", "copas", "espadas", "oros"};
  
  private String strNumero;
  private String strPalo;

  public Carta() {
    this.strNumero = strValor[(int)(Math.random()*10)];
    this.strPalo = strPal[(int)(Math.random()*4)];
  }
  
  public String getNumero() {
    return strNumero;
  }

  public String getPalo() {
    return strPalo;
  }

  @Override
  public String toString() {
    return this.strNumero + " de " + this.strPalo;
  }
  
  @Override
  public boolean equals(Object obj) {
	  if (obj == null || //si el objeto con el que me quiero comparar es nulo o no es de mi clase
    	this.getClass() != obj.getClass()) 
		  return false; 

    if (Objects.equals(this.strNumero, ((Carta)obj).strNumero) &&
    	Objects.equals(this.strPalo, ((Carta)obj).strPalo))
      return true;
    
    return false;
  }

	@Override
	public int compareTo(Carta objCarta) {
		if (this.strPalo.equals(objCarta.getPalo())) //si el palo es igual, comparo por número
		    //si no miro el índice me dirá que cinco es menor de tres y cuatro (onden cadena)  
			return Carta.indice(this.strNumero).compareTo(Carta.indice(objCarta.getNumero()));
		else // si no es igual, devuelvo cual es mayor
		      return this.strPalo.compareTo(objCarta.getPalo());
	}

	/*Devuelve el valor del índice de la cadena del número*/
	private static Integer indice(String strNumero) {
		int intCont;
		for(intCont=0; intCont<Carta.strValor.length && !Carta.strValor[intCont].equals(strNumero);intCont++);
		if(intCont==Carta.strValor.length)
			return null;
		else
			return intCont;
	}
}

