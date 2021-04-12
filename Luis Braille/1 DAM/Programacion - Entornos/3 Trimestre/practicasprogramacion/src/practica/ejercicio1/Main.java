package practica.ejercicio1;

public  class Main {
    /**
     * 1.- Definir un método genérico que determine el máximo de un array de cualquier tipo. Realizar un programa que 
     * utilice este método genérico para calcular y escribir los máximos de los siguientes arrays de números: 
     * a) racionales
     * b) complejos
     * c) reales (double).
     * @param args
     */
    public static void main(String[] args) {
    	Racional arrRacional[] = {new Racional(5, 2), new Racional(4, 3), new Racional(8, 9), new Racional(15, 4)};
    	Real arrReal[] = {new Real(15.54), new Real(1.5798), new Real(2.587)};
    	Complejo arrComplejo[] = {new Complejo(2.0, 3.0), new Complejo(1.45, 2.0),new Complejo(5, 4)};
    }
    
    public static <T extends > T maximo(T arr[]) {
    	T aux = arr[0];
    	
    	for (int intI = 0; intI < arr.length; intI++) {
			aux.
		}
    	
		return null;
    	
    }
}
