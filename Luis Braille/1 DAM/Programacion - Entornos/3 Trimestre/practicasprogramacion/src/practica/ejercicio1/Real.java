package practica.ejercicio1;

public class Real implements Mayor<Real> {
	private double douReal;

	public Real(double douReal) {
		this.douReal = douReal;
	}

	public double getDouReal() {
		return douReal;
	}

	@Override
	public boolean mayor(Real ojbComparar) {
		if (douReal > ojbComparar.douReal)
			return true;
		else
			return false;
	}

	@Override
	public String toString() {
		return "Real [douReal=" + douReal + "]";
	}

}
