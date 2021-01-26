package almacenar;

public class Main {

	public static void main(String[] args) {
		Serie theMandalorian = new Serie("The Mandalorian", "Dave Filoni", "Sci-Fi", 2);
		Serie strangerThings = new Serie();
		
		strangerThings.setStrTitulo("Stranger Things");
		
		System.out.println(theMandalorian.toString());
		System.out.println(strangerThings.toString());
	}

}
