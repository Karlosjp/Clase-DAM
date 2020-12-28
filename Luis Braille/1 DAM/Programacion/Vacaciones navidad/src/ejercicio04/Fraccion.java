package ejercicio04;

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
		this.intDen = intDen;
	}

	public Fraccion sumar(Fraccion fraccion) {
		Fraccion aux = new Fraccion();
		
		aux.intNum = this.intNum * fraccion.intDen + this.intDen * fraccion.intNum;
		aux.intDen = this.intDen * fraccion.intDen;
		
		//aux.simplificar(); 
		
		return aux;
	}

	public Fraccion restar(Fraccion fraccion) {
		
		return fraccion;
	}

	public Fraccion multiplicar(Fraccion fraccion) {

		return fraccion;
	}

	public Fraccion dividir(Fraccion fraccion) {

		return fraccion;
	}

}
