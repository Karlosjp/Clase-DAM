package practica.ejercicio1;

public class Complejo implements Mayor<Complejo> {
	private double intImaginaria, intReal;

	public Complejo(double intImaginaria, double intReal) {
		this.intImaginaria = intImaginaria;
		this.intReal = intReal;
	}

	public double getIntImaginaria() {
		return intImaginaria;
	}

	public double getIntReal() {
		return intReal;
	}

	public double calcular() {
		return Math.sqrt(Math.pow(intReal, 2) + Math.pow(intImaginaria, 2));
	}

	@Override
	public boolean mayor(Complejo ojbComparar) {
		if (this.calcular() > ojbComparar.calcular())
			return true;
		else
			return false;
	}

	@Override
	public String toString() {
		return "Complejo [intImaginaria=" + intImaginaria + ", intReal=" + intReal + "]";
	}
}
