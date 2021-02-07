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

	private final String STRNUM = "13225", STRNOM = "Carlos";
	private final double DOUCREDITO = 1000, DOUINGRESO = 500;

	@Before
	public void beforeCuenta() throws Exception {
		objCuenta = new Cuenta(STRNUM, STRNOM);
		date = new Date();
		objCuenta.ingresar(DOUINGRESO);
	}

	@Test
	public void testVerSaldo() throws Exception {
		assertEquals(DOUINGRESO, objCuenta.getSaldo());
	}

	@Test
	public void testRetirarDouble500() throws Exception {
		objCuenta.retirar("Sacar dinero", DOUINGRESO);

		assertEquals(0, objCuenta.getSaldo());
	}

	@Test
	public void testRetirarDouble300() throws Exception {
		objCuenta.retirar("Sacar dinero", 300);

		assertEquals(200, objCuenta.getSaldo());
	}

	@Test
	public void testRetirarDebito() throws Exception {
		objDebito = new Debito(STRNUM, STRNOM, date);
		objDebito.setCuenta(objCuenta);
		objDebito.retirar(DOUINGRESO);

		assertEquals(0, objDebito.getSaldo());
	}

	@Test
	public void testIngresarCredito() throws Exception {
		objCredito = new Credito(STRNUM, STRNOM, date, DOUCREDITO);
		objCredito.setCuenta(objCuenta);
		objCredito.ingresar(DOUINGRESO);
		
		assertEquals(DOUCREDITO, objCuenta.getSaldo());
	}
	
	@Test
	public void testLiquidarCredito() throws Exception {
		objCredito = new Credito(STRNUM, STRNOM, date, DOUCREDITO);
		objCredito.setCuenta(objCuenta);
		
		objCredito.pagoEnEstablecimiento("Pago 1", 100);
		objCredito.pagoEnEstablecimiento("Pago 2", 200);
		objCredito.liquidar(2,2021);
		
		assertEquals(200, objCuenta.getSaldo());
	}
}
