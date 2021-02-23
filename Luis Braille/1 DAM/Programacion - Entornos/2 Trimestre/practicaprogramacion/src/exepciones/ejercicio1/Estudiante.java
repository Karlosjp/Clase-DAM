package exepciones.ejercicio1;

import java.util.Date;

public class Estudiante extends Persona {

	private String strCurso;
	
	public Estudiante(String strNombre, String strSexo, String strDireccion, Date objFechaNacimiento, String strCurso) {
		super(strNombre, strSexo, strDireccion, objFechaNacimiento);
		this.strCurso = strCurso;
	}

	@Override
	public String toString() {
		return super.toString() + " Estudiante [Curso=" + strCurso + "]";
	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = super.hashCode();
		result = prime * result + ((strCurso == null) ? 0 : strCurso.hashCode());
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
		if (strCurso == null) {
			if (other.strCurso != null)
				return false;
		} else if (!strCurso.equals(other.strCurso))
			return false;
		return true;
	}
	
	
}
