package tema5.ejercicio2;

public class Cliente extends Persona {
	private String srtTelefonoContacto;

	public Cliente(String strNombre, int intEdad, String srtTelefonoContacto) {
		super(strNombre, intEdad);

		this.srtTelefonoContacto = srtTelefonoContacto;
	}

	@Override
	public void mostrar() {
		super.mostrar();
		System.out.println("Telefono de contacto: " + srtTelefonoContacto);
	}
}
