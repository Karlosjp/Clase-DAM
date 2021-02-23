package exepciones.ejercicio1;

import java.util.Date;

public class Trabajador extends Persona {

	private String strPuesto;

	public Trabajador(String strNombre, String strSexo, String strDireccion, Date objFechaNacimiento,
			String strPuesto) {
		super(strNombre, strSexo, strDireccion, objFechaNacimiento);
		this.strPuesto = strPuesto;
	}

	@Override
	public String toString() {
		return super.toString() + "Trabajador [Puesto=" + strPuesto + "]";
	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = super.hashCode();
		result = prime * result + ((strPuesto == null) ? 0 : strPuesto.hashCode());
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
		if (strPuesto == null) {
			if (other.strPuesto != null)
				return false;
		} else if (!strPuesto.equals(other.strPuesto))
			return false;
		return true;
	}

}
