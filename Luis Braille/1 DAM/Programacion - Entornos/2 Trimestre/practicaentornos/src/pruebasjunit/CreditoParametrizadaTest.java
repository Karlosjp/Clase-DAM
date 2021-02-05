package pruebasjunit;

import static org.junit.Assert.*;
import static org.junit.jupiter.api.Assertions.assertEquals;

import java.util.Arrays;
import java.util.Date;

import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.Parameterized;
import org.junit.runners.Parameterized.Parameters;

@RunWith(value = Parameterized.class)
public class CreditoParametrizadaTest {
	
	private double douExpected, douRetirar;
	private Date today;
	private Cuenta objCuenta;
	private Credito objCredito;
	private final String STRNUM = "13225", STRNOM = "Carlos";
	private final double DOUCREDITO = 1000;

	
	/**
	 * Hace tantas pruebas como objetos dentro del array de la funcion getData()
	 * @return
	 */
	@Parameters
	public static Iterable<Object[]> getData(){
		return Arrays.asList(new Object[][] { 
			// Da error, el 5% de 500 son 25 no 15
			{ 15 , 500},
			// Los quita correctamente
			{ 3, 50 }});
	}
	
	// Constructor para poder reutilizar la clase, Recibe cantidad a retirar y comision que deberia quitar
	public CreditoParametrizadaTest(double douExpected, double douRetirar) {
		this.douExpected = douExpected;
		this.douRetirar = douRetirar;
	}
	
	@Before
	public void before() {
		// Crea un objeto Date
		today = new Date();
		// Crea un objeto Cuenta
		objCuenta = new Cuenta(STRNUM, STRNOM);
		// Crea un objeto Credito-Tarjeta
		objCredito = new Credito(STRNUM, STRNOM, today, DOUCREDITO);
		// Asigna el objeto Cuenta a Credito-Tarjeta
		objCredito.setCuenta(objCuenta);
	}
	
	@Test
	public void test() throws Exception {
		// Retira la cantidad especificada
		objCredito.retirar(douRetirar);
		
		assertEquals(DOUCREDITO - douExpected, objCredito.getCreditoDisponible());
	}

}
