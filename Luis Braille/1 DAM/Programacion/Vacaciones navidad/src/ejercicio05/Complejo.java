package ejercicio05;

public class Complejo {
	private double douReal, douImaginaria;

	public Complejo() {
		this.douImaginaria = 0;
		this.douReal = 0;
	}

	public Complejo(double douReal, double douImaginaria) {
		this.douImaginaria = douImaginaria;
		this.douReal = douReal;
	}

	public double getDouReal() {
		return douReal;
	}

	public void setDouReal(double douReal) {
		this.douReal = douReal;
	}

	public double getDouImaginaria() {
		return douImaginaria;
	}

	public void setDouImaginaria(double douImaginaria) {
		this.douImaginaria = douImaginaria;
	}

	/**
	 * Suma 2 numeros complejos
	 * 
	 * @param complejo
	 * @return Complejo
	 */
	public Complejo sumar(Complejo complejo) {
		Complejo aux = new Complejo();

		aux.douReal = complejo.douReal + this.douReal;
		aux.douImaginaria = complejo.douImaginaria + this.douReal;

		return aux;
	}

	/**
	 * Resta 2 numeros complejos
	 * 
	 * @param complejo
	 * @return Complejo
	 */
	public Complejo restar(Complejo complejo) {
		Complejo aux = new Complejo();

		aux.douReal = complejo.douReal - this.douReal;
		aux.douImaginaria = complejo.douImaginaria - this.douReal;

		return aux;
	}

	/**
	 * Multiplica un numero completjo por un numero double
	 * 
	 * @param douNum
	 * @return Complejo
	 */
	public Complejo multiplicar(double douNum) {
		Complejo aux = new Complejo();

		aux.douReal = this.douReal * douNum;
		aux.douImaginaria = this.douImaginaria * douNum;
		
		return aux;
	}

	/**
	 * Multiplica 2 numeros complejos
	 * 
	 * @param complejo
	 * @return Complejo
	 */
	public Complejo multiplicar(Complejo complejo) {
		Complejo aux = new Complejo();

		aux.douReal = this.douReal * complejo.douReal - this.douImaginaria * complejo.douImaginaria;
		aux.douImaginaria = this.douReal * complejo.douImaginaria - this.douImaginaria * complejo.douReal;

		return aux;
	}

	/**
	 * Divide 2 numeros complejos
	 * 
	 * @param complejo
	 * @return Complejo
	 */
	public Complejo dividir(Complejo complejo) {
		Complejo aux = new Complejo();
		double douCuadrado = complejo.douReal * complejo.douReal + complejo.douImaginaria * complejo.douImaginaria;

		aux.douReal = (this.douReal * complejo.douReal + this.douImaginaria * complejo.douImaginaria) / douCuadrado;
		aux.douImaginaria = (this.douImaginaria * complejo.douReal - this.douReal * complejo.douImaginaria) / douCuadrado;

		return aux;
	}
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return "(" + this.douReal + ", " + this.douImaginaria + ")";
	}
	
	@Override
	public boolean equals(Object obj) {
		if(obj == null || this.getClass() != obj.getClass())
			return false;
		
		final Complejo other = (Complejo) obj;
		
		if (this.douReal != other.douReal || this.douImaginaria != other.douImaginaria)
			return false;
			
		return true;
	}

}
