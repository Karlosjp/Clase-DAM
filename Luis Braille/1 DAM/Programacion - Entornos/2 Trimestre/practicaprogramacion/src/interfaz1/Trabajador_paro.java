package interfaz1;

public class Trabajador_paro extends Persona{
	private int intCodigoParo;

	public Trabajador_paro(String strNombre, String strDireccion, String strFecha_Nacimiento, String srtSexo,
			int intCodigoParo) {

		this.intCodigoParo = intCodigoParo;
	}

	public Trabajador_paro() {
		super();

	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = super.hashCode();
		result = prime * result + intCodigoParo;
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
		Trabajador_paro other = (Trabajador_paro) obj;
		if (intCodigoParo != other.intCodigoParo)
			return false;
		return true;
	}

	@Override
	public String toString() {
		return "Trabajador_paro [intCodigoParo=" + intCodigoParo + "]";
	}
	
	
}
