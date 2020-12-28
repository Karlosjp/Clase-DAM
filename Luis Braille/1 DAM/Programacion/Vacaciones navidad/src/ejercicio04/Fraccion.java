package ejercicio04;

import java.util.ArrayList;

public class Fraccion {
	private int intNum, intDen;

	public Fraccion() {
		this.intNum = 0;
		this.intDen = 1;
	}

	public Fraccion(int intNum) {
		this.intNum = intNum;
		this.intDen = 1;
	}

	public Fraccion(int intNum, int intDen) {
		this.intNum = intNum;
		
		if (intDen == 0)
			intDen = 1;
		
		this.intDen = intDen;
		
		simplificar();
	}

	public Fraccion sumar(Fraccion fraccion) {
		Fraccion aux = new Fraccion();

		aux.intNum = intNum * fraccion.intDen + intDen * fraccion.intNum;
		aux.intDen = intDen * fraccion.intDen;

		aux.simplificar();

		return aux;
	}

	public Fraccion restar(Fraccion fraccion) {
		Fraccion aux = new Fraccion();

		aux.intNum = intNum * fraccion.intDen - intDen * fraccion.intNum;
		aux.intDen = intDen * fraccion.intDen;

		aux.simplificar();

		return aux;
	}

	public Fraccion multiplicar(Fraccion fraccion) {
		Fraccion aux = new Fraccion();
		
		aux.intNum = this.intNum * fraccion.intNum;
		aux.intDen = this.intDen * fraccion.intDen;
		
		aux.simplificar();
		
		return aux;
	}

	public Fraccion dividir(Fraccion fraccion) {
		Fraccion aux = new Fraccion();

		aux.intNum = this.intNum * fraccion.intDen;
		aux.intDen = this.intDen * fraccion.intNum;
		
		aux.simplificar();
		
		return aux;
	}

	private int mcd() {
		int intN = Math.abs(intNum);
		int intD = Math.abs(intDen);
		int intR;

		if (intD == 0) {
			return intN;
		}

		while (intD != 0) {
			intR = intN % intD;
			intN = intD;
			intD = intR;
		}

		return intN;
	}

	private void simplificar() {
		int intMCD = mcd();

		intNum = intNum / intMCD;
		intDen = intDen / intMCD;
	}

	@Override
	public String toString() {
		simplificar();

		return intNum + "/" + intDen;
	}

}
