package interfaz1;

public class Trabajador_Autonomo extends Persona {
	private int intCodigoAutonomo;

	public Trabajador_Autonomo(String strNombre, String strDireccion, String strFecha_Nacimiento, String srtSexo,
			int intCodigoAutonomo) {
		this.intCodigoAutonomo = intCodigoAutonomo;
	}

	public Trabajador_Autonomo() {

	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = super.hashCode();
		result = prime * result + intCodigoAutonomo;
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
		Trabajador_Autonomo other = (Trabajador_Autonomo) obj;
		if (intCodigoAutonomo != other.intCodigoAutonomo)
			return false;
		return true;
	}

	@Override
	public String toString() {
		return "Trabajador_Autonomo [intCodigoAutonomo=" + intCodigoAutonomo + "]";
	}
	
	
}
