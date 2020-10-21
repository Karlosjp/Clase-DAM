package clases;

public class Coche {

	// Atributos

	private int nCaballos, marcha;
	private String direccion, matricula;

	// Constructores
	public Coche() {
		direccion = "PARADO";
		marcha = 0;
		matricula = "DESCONOCIDA";
		nCaballos = 5;
	}

	public Coche(int nCaballos, int marcha, String direccion, String matricula) {
		this.nCaballos = nCaballos;
		this.marcha = marcha;
		this.direccion = direccion;
		this.matricula = matricula;
	}

	// Metodos
	public void arrancar() {
		direccion = "DELANTE";
		marcha++;
	}

	public void girar(String dir) {
		switch (dir) {
			case "i" :
				direccion = "IZQUIERDA";
				break;
			case "d" :
				direccion = "DERECHA";
		}
	}

	public void parar() {
		marcha = 0;
		direccion = "PARADO";
	}

	// Geters and Seters
	public String getDireccion() {
		return direccion;
	}

	public int getNCaballos() {
		return nCaballos;
	}

	public void setMatricula(String matricula) {
		this.matricula = matricula;
	}

	public void setMarcha(int marcha) {
		this.marcha = marcha;
	}

	public String estado() {
		return "Caballos: " + nCaballos + " Direccion: " + direccion + " Marcha: " + marcha + " Matriculaa: "
				+ matricula;
	}
}
