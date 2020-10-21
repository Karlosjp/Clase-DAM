package metodos_01;

public class MetodosRetum {

	public static int buscarValor(int[] tabla, int valor) {
		for (int i = 0; i < 5; i++) {
			if (valor == tabla[i])
				return i;
		}
		return -1;
	}

	public static int buscarValor2(int[] tabla, int valor) {
		int devolver = -1;
		boolean encontrado = false;
		for (int i = 0; (i < 5) && (!encontrado); i++) {
			if (valor == tabla[i]) {
				devolver = i;
				encontrado = true;
			}
		}
		return -1;
	}

	public static void main(String[] args) {
		int[] miTabla1 = new int[5];
		int[] miTabla2 = {12, 5, 8, 74, 16};

	}
}
