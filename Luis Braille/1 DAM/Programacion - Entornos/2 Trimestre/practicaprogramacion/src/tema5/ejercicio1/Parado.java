package tema5.ejercicio1;

import java.util.Date;

public class Parado extends Persona {

	private int intDuracion;

	public Parado(String strNombre, String strSexo, String strDireccion, Date objFechaNacimiento, String strDuracion) {
		super(strNombre, strSexo, strDireccion, objFechaNacimiento);
		this.intDuracion = Integer.parseInt(strDuracion);
	}

	@Override
	public void imprimir() {
		super.imprimir();
		System.out.println("Duracion" + intDuracion);
	}
	
	@Override
	public String toString() {
		return super.toString() + " Parado [intDuracion=" + intDuracion + "]";
	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = super.hashCode();
		result = prime * result + intDuracion;
		return result;
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (!super.equals(obj))
			return false;
		if (getClass() != obj.getClass())
			return false;
		Parado other = (Parado) obj;
		if (intDuracion != other.intDuracion)
			return false;
		return true;
	}

}
