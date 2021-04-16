package ejercicio.tema8.ejercicio13;

public class Cuenta {
	private String strNumCuenta;
	private double douSaldo;

	public Cuenta(String strNumCuenta) {
		this.strNumCuenta = strNumCuenta;
		this.douSaldo = 0;
	}

	public Cuenta(String strNumCuenta, double douSaldo) {
		this.strNumCuenta = strNumCuenta;
		this.douSaldo = douSaldo;
	}

	public String getStrNumCuenta() {
		return strNumCuenta;
	}

	public double getDouSaldo() {
		return douSaldo;
	}

	public Movimiento ingreso(double douImporte) {
		douSaldo += douImporte;
		return new Movimiento("Ingreso", strNumCuenta, douImporte);
	}

	public Movimiento cargo(double douImporte) {
		douSaldo -= douImporte;
		return new Movimiento(strNumCuenta, "Cargo", douImporte);
	}

	public Movimiento emitirTransferencia(Cuenta objCuenta, double douCantidad) {
		this.douSaldo -= douCantidad;
		objCuenta.ingreso(douCantidad);

		return new Movimiento(this.strNumCuenta, objCuenta.strNumCuenta, douCantidad);
	}
}
