package practica.ejercicio2;

import java.util.HashSet;

public class Main {
	/**
	 * 2.- Generar un diccionario de español a inglés por medio de un mapa. Puede
	 * haber varias palabras que se traduzcan al ingles de la misma forma como
	 * pueden ser: tienda shop, store; llegar come, arrive; medio center, middle...
	 * Se irán pidiendo palabras para sacar sinónimos. Si la palabra no existe nos
	 * ofrece meterla en el diccionario Si la palabra existe pero no tiene sinónimos
	 * nos permite meter sinónimos. Si la palabra existe y tiene sinónimos nos los
	 * muestra. Preguntar si quiere introducir más palabras o quiere salir
	 * 
	 * @param args
	 */
	public static void main(String[] args) {
		Alumno a1 = new Alumno("alberto", 7);
		Alumno a2 = new Alumno("alberto", 6);
		Alumno a3 = new Alumno("alberto", 7);
		Alumno a4 = new Alumno("adrian", 7);
		Alumno a5 = new Alumno("alberto", 7);
		Alumno a6 = new Alumno("adrian", 8);

		HashSet<Alumno> l = new HashSet<Alumno>();

		l.add(a1);
		l.add(a2);
		l.add(a3);
		l.add(a4);
		l.add(a5);
		l.add(a6);

		for (Alumno alumno : l) {
			System.out.println(alumno);
		}
	}
}
