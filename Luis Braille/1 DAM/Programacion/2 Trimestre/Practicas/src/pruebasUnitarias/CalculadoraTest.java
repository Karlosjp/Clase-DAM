package pruebasUnitarias;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import org.junit;

class CalculadoraTest {
	private Calculadora objCalculadora = new Calculadora();

	@BeforeEach
	public void beforeEach() {

	}
	
	@Before 

	@Test
	void test() {
		assertEquals(3, objCalculadora.suma(1, 2));
	}

}
