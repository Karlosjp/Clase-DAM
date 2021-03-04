package examen.ejercicio3;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Electrico objElectrico;
		Combustion objCombustión;
		Scanner scnLeer = new Scanner(System.in);

		int intAux;
		Vehiculo[] arrObjVehiculos = new Vehiculo[1];

		for (int intCont = 0; intCont < arrObjVehiculos.length; intCont++) {
			do {
				System.out.println("Indica el tipo de vehiculo \n 0.- Electrico \n 1.- Gasolina");
				intAux = scnLeer.nextInt();
			} while (intAux != 0 && intAux != 1);

			if (intAux == 0) {
				System.out.println("Indica el precio");
				intAux = scnLeer.nextInt();

				arrObjVehiculos[intCont] = new Electrico(intAux);
			} else {
				System.out.println("Indica la cilindrada");
				intAux = scnLeer.nextInt();

				arrObjVehiculos[intCont] = new Combustion(intAux);
			}
		}

		for (int intCont = 0; intCont < arrObjVehiculos.length; intCont++)
			System.out.println("El "+ arrObjVehiculos[intCont].getClass() +" paga " + arrObjVehiculos[intCont].impuesto());
	}

}
