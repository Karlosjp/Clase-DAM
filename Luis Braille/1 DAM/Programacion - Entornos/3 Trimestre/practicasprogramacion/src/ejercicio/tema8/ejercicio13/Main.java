package ejercicio.tema8.ejercicio13;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;

public class Main {

	static HashMap<String, Movimiento> hsMovimientos = new HashMap<String, Movimiento>();

	public static void main(String[] args) {
		Cuenta objCuenta1 = new Cuenta(generaNumeroCuenta());
		Cuenta objCuenta2 = new Cuenta(generaNumeroCuenta());
		Cuenta objCuenta3 = new Cuenta(generaNumeroCuenta());
		Cuenta objCuenta4 = new Cuenta(generaNumeroCuenta(), 2000);
		Cuenta objCuenta5 = new Cuenta(generaNumeroCuenta(), 521.85);
		Cuenta objCuenta6 = new Cuenta(generaNumeroCuenta(), 5212.85);

		crearMovimiento(545, "ingreso", objCuenta1, null);
		crearMovimiento(50, "transferencia", objCuenta6, objCuenta1);
		crearMovimiento(1231, "ingreso", objCuenta2, null);
		crearMovimiento(10, "transferencia", objCuenta1, objCuenta3);
		crearMovimiento(5, "cargo", objCuenta2, null);
		crearMovimiento(5, "transferencia", objCuenta1, objCuenta2);
		crearMovimiento(60, "transferencia", objCuenta5, objCuenta4);
		crearMovimiento(545, "ingreso", objCuenta4, null);
		crearMovimiento(350, "cargo", objCuenta4, null);
		crearMovimiento(150, "transferencia", objCuenta6, objCuenta5);
		crearMovimiento(250, "transferencia", objCuenta5, objCuenta1);
		crearMovimiento(200, "ingreso", objCuenta5, null);
		crearMovimiento(150, "cargo", objCuenta5, null);
		crearMovimiento(10, "cargo", objCuenta1, null);

		for (String strKey : hsMovimientos.keySet())
			System.out.println(hsMovimientos);
	}

	public static void crearMovimiento(double douCantidad, String strTipo, Cuenta objCuenta, Cuenta objCuenta2) {
		switch (strTipo) {
		case "transferencia":
			hsMovimientos.put(objCuenta.getStrNumCuenta(), objCuenta.emitirTransferencia(objCuenta2, douCantidad));
			break;
		case "ingreso":
			hsMovimientos.put(objCuenta.getStrNumCuenta(), objCuenta.ingreso(douCantidad));
			break;
		case "cargo":
			hsMovimientos.put(objCuenta.getStrNumCuenta(), objCuenta.cargo(douCantidad));
			break;
		}
	}

	public static String generaNumeroCuenta() {
		return String.valueOf((int) (Math.random() * 1000000000));
	}
}
