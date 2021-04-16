package ejercicio.tema8.ejercicio13;

public class Movimiento {
	private String strEmisor, strDestino;
	private double douCantidad;
	
	public Movimiento(String strEmisor, String strDestino, double douCantidad) {
		this.strEmisor = strEmisor;
		this.strDestino = strDestino;
		this.douCantidad = douCantidad;
	}

	@Override
	public String toString() {
		return "Movimiento [Emisor= " + strEmisor + ", Destino=" + strDestino
				+ ", Cantidad=" + douCantidad + "]";
	}
	
	
}
