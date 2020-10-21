
public class Ejercicio7 {
	
	public static void main (String [] args) {
		
		Ejercicio7Prof p1 = new Ejercicio7Prof("05694873R", "Txema", "Alonso Pérez", 1354.67, 6, true);
		Ejercicio7Admon a1 = new Ejercicio7Admon("06884241B", "Enrique", "Lopez Jimenez", 1250.41, 'V', 6);
		Ejercicio7Dir d1 = new Ejercicio7Dir("05339808L", "Francisco", "Sanchez Garcia", 1889.91, false, 'T');
		
		System.out.println(p1.toString());
		System.out.println(a1.toString());
		System.out.println(d1.toString());
	
		System.out.println(d1.getDni().toString());
		
	}
	
}
