package interfaz1;

public class Estudiante extends Persona{
	private int intCodigoEstudiante;

	public Estudiante(String strNombre, String strDireccion, String strFecha_Nacimiento, String srtSexo,
			int intCodigoEstudiante) {
		this.intCodigoEstudiante = intCodigoEstudiante;
	}

	public Estudiante() {
	
	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = super.hashCode();
		result = prime * result + intCodigoEstudiante;
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
		Estudiante other = (Estudiante) obj;
		if (intCodigoEstudiante != other.intCodigoEstudiante)
			return false;
		return true;
	}

	@Override
	public String toString() {
		return "Estudiante [intCodigoEstudiante=" + intCodigoEstudiante + "]";
	}





	
	
}
