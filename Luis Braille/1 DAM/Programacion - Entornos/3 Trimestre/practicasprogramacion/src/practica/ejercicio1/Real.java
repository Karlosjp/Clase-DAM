package practica.ejercicio1;

public class Real {
	private double douReal;

	public Real(double douReal) {
		this.douReal = douReal;
	}

	@Override
	public String toString() {
		return "Real [douReal=" + douReal + "]";
	}

	public double getDouReal() {
		return douReal;
	}

	public int comparar(Real objReal) {
		if (douReal > objReal.douReal)
			return 1;
		else if (douReal < objReal.douReal)
			return -1;
		else
			return 0;
	}

}
