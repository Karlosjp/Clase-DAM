package pruebastest;


public class Calculadora {
	private int intNum1;
	private int intNum2;
	
	public void setIntNum1(int intNum1) {
		this.intNum1 = intNum1;
	}

	public void setIntNum2(int intNum2) {
		this.intNum2 = intNum2;
	}

	public Calculadora(int intNum1, int intNum2) {
		this.intNum1 = intNum1;
		this.intNum2 = intNum2;
	}
	
	public Calculadora() {
	}

	public int suma() {
		return this.intNum1+this.intNum2;
	}
	public int suma(int intA, int intB) {
		return intA+intB;
	}
	public int resta() {
		int intResultado;
		
		if(this.intNum1>this.intNum2)
			intResultado=this.intNum1-this.intNum2;
		else
			intResultado=this.intNum2-this.intNum1;
		
		return intResultado;
	}
	
	public int multiplica() {
		return this.intNum1*this.intNum2;
	}
	
	public int divide() {
		int intResultado;
		
		if(this.intNum1>this.intNum2)
			intResultado=this.intNum1/this.intNum2;
		else
			intResultado=this.intNum2/this.intNum1;
		
		return intResultado;
	}
	
	public boolean mayor() {
		if(this.intNum1>this.intNum2)
			return true;
		else
			return false;
	}
	
	public double repetitivo() {
		double rlnValor;
		
		for (rlnValor=0;rlnValor<10000;rlnValor+=0.0001);
		return 3;
	}
}
