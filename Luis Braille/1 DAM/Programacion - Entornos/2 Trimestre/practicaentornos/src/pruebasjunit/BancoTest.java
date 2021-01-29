package pruebasjunit;

import static org.junit.jupiter.api.Assertions.*;

import java.util.Date;

import org.junit.Before;
import org.junit.Test;

public class BancoTest {
	Cuenta objCuenta;
	Debito objDebito;
	Credito objCredito;
	Date date;

	final String NUMERO = "13225", NOMBRE = "Carlos";

	@Before
	public void beforeCuenta() throws Exception {
		objCuenta = new Cuenta(NUMERO, NOMBRE);
		date = new Date();
		objCuenta.ingresar(500);
		System.out.println("Before: " + objCuenta.getSaldo());
	}

	@Test
	public void testVerSaldo() throws Exception {
		assertEquals(500, objCuenta.getSaldo());
	}

	@Test
	public void testRetirarDouble500() throws Exception {
		objCuenta.retirar("Sacar dinero", 500);

		assertEquals(0, objCuenta.getSaldo());
	}

	@Test
	public void testRetirarDouble300() throws Exception {
		objCuenta.retirar("Sacar dinero", 300);

		assertEquals(200, objCuenta.getSaldo());
	}

	@Test
	public void testRetirarDebito() throws Exception {
		objDebito = new Debito(NUMERO, NOMBRE, date);
		objDebito.setCuenta(objCuenta);
		objDebito.retirar(500);

		assertEquals(0, objDebito.getSaldo());
	}

	@Test
	public void testIngresarCredito() throws Exception {
		objCredito = new Credito(NUMERO, NOMBRE, date, 2000);
		objCredito.setCuenta(objCuenta);
		objCredito.ingresar(500);
		
		assertEquals(1000, objCuenta.getSaldo());
	}
	
	@Test
	public void testRetirarCredito500() throws Exception {
		objCredito = new Credito(NUMERO, NOMBRE, date, 2000);
		objCredito.setCuenta(objCuenta);
		
		objCredito.retirar(500);
		
		assertEquals(2000-15, objCredito.getCreditoDisponible());
	}
	
	@Test
	public void testRetirarCredito50() throws Exception {
		objCredito = new Credito(NUMERO, NOMBRE, date, 2000);
		objCredito.setCuenta(objCuenta);
		
		objCredito.retirar(50);
		
		assertEquals(2000-3, objCredito.getCreditoDisponible());
	}
	
	@Test
	public void testLiquidarCredito() throws Exception {
		objCredito = new Credito(NUMERO, NOMBRE, date, 2000);
		objCredito.setCuenta(objCuenta);
		
		objCredito.pagoEnEstablecimiento("Pago 1", 100);
		objCredito.pagoEnEstablecimiento("Pago 2", 200);
		objCredito.liquidar(3,2020);
		
		assertEquals(200, objCredito.getSaldo());
	}
}
