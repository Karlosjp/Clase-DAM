package practica.ejercicio1;

public class Complejo extends Numero{
	private double intImaginaria, intReal;

	public Complejo(double intImaginaria, double intReal) {
		this.intImaginaria = intImaginaria;
		this.intReal = intReal;
	}

	@Override
	public String toString() {
		return "Complejo [intImaginaria=" + intImaginaria + ", intReal=" + intReal + "]";
	}

	@Override
	public <Complejo> int comparar(T objComplejo) {
		if (this.calcular() > objComplejo.calcular())
			return 1;
		else if (this.calcular() < objComplejo.calcular())
			return -1;
		else
			return 0;

	}

	public double getIntImaginaria() {
		return intImaginaria;
	}

	public double getIntReal() {
		return intReal;
	}
	
	@Override
	private double calcular() {
		return Math.sqrt(Math.pow(intReal, 2) + Math.pow(intImaginaria, 2));
	}
}
