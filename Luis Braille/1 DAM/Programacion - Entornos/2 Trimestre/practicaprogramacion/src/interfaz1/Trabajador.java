package interfaz1;

public class Trabajador extends Persona{
	private int intCodigoTrabajador;

	public Trabajador(String strNombre, String strDireccion, String strFecha_Nacimiento, String srtSexo,
			int intCodigoTrabajador) {
		this.intCodigoTrabajador = intCodigoTrabajador;
	}

	public Trabajador() {

	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = super.hashCode();
		result = prime * result + intCodigoTrabajador;
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
		Trabajador other = (Trabajador) obj;
		if (intCodigoTrabajador != other.intCodigoTrabajador)
			return false;
		return true;
	}

	@Override
	public String toString() {
		return "Trabajador [intCodigoTrabajador=" + intCodigoTrabajador + "]";
	}
	
	
}
