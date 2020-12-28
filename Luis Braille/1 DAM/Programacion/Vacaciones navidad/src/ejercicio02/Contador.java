package ejercicio02;

import java.util.function.IntConsumer;

public class Contador {
	private int intCont;

	public Contador() {
		this.intCont = 0;
	}

	public Contador(int intCount) {
		if(intCount >= 0)
			this.intCont = intCount;
		else
			this.intCont = 0;
	}
	
	public Contador(Contador contador) {
		this.intCont = contador.getIntCont();
	}

	public int getIntCont() {
		return intCont;
	}

	public void setIntCont(int intCount) {
		this.intCont = intCount;
	}
	
	public void incrementa() {
		this.intCont++;
	}
	
	public void decrementa() {
		if(this.intCont > 0)
			this.intCont--;
		else
			this.intCont = 0;
	}
}
