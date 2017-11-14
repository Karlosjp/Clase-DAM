package clases;

public class Concesionario {

	public static void retirar(Coche[] coches) {
		for (int i = 0; i < coches.length; i++)
			coches[i].setMatricula("0000XXX");
	}

	public static void cParados(Coche[] coches) {
		for (int i = 0; i < coches.length; i++)
			if (coches[i].getDireccion() == "PARADO")
				coches[i].setMarcha(0);
	}

	public static void ordenar(Coche[] coches) {
		Coche cAux;
		for (int i = 0; i < coches.length - 1; i++)
			for (int j = 0; j < coches.length - 1; j++)
				if (coches[j].getNCaballos() > coches[j + 1].getNCaballos()) {
					cAux = coches[j];
					coches[j] = coches[j + 1];
					coches[j + 1] = cAux;
				}
		imprimir(coches);
	}

	public static void imprimir(Coche[] coches) {
		for (int i = 0; i < coches.length; i++)
			System.out.println(coches[i].estado());
	}

	public static void main(String[] args) {
		Coche c1 = new Coche(100, 3, "Delante", "3154HRF"), c2 = new Coche(150, -1, "DELANTE", "1234FRS"),
				c3 = new Coche(80, -1, "ATRAS", "2345BDR");

		Coche[] coches = {c1, c2, c3};

		c1.arrancar();
		c1.girar("D");

		c2.girar("I");

		c3.arrancar();
		c3.girar("I");
		c3.parar();

		System.out.println("Coche 1" + c1.estado());
		System.out.println("Coche 2" + c2.estado());
		System.out.println("Coche 3" + c3.estado());

		ordenar(coches);
	}
}
