package tema5.ejercicio3;

public class Main {

	public static void main(String[] args) {
		int arrIntZ[] = { 14, 13, 8, 7, 6, 12, 11, 10, 9, -5, 1, 5 };

		ordenar(arrIntZ, 12);

		for (int i = 0; i < 12; i++)
			System.out.print(arrIntZ[i] + " ");

	}

	public static void intercambio(int intX, int intY) {
		int intAux;
		intAux = intX;
		intX = intY;
		intY = intAux;
	}

	public static void ordenar(int[] arrIntV, int intN) {
		int intI, intJ;
		
		for (intI = 0; intI < intN; ++intI)
			for (intJ = 0; intJ < intN; ++intJ) {
				try {
					if (arrIntV[intJ] < arrIntV[intJ + 1])
						intercambio(arrIntV[intJ], arrIntV[intJ + 1]);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
	}

}
