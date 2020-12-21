package almacenar;

public class Main {

	public static void main(String[] args) {
		Serie primera = new Serie("The Mandalorian", 2, "Sci-Fi", "Dave Filoni");
		Serie segunda = new Serie();
		
		segunda.setIntNumTemp(3);
		segunda.setStrTitulo("Stranger Things");
		
		System.out.println(primera);
		System.out.println(segunda);
	}

}
