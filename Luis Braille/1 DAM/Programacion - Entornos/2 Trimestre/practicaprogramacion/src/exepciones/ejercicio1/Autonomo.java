package exepciones.ejercicio1;

import java.util.Date;

public class Autonomo extends Persona {

	private String strEmpresa;

	public Autonomo(String strNombre, String strSexo, String strDireccion, Date objFechaNacimiento, String strEmpresa) {
		super(strNombre, strSexo, strDireccion, objFechaNacimiento);
		this.strEmpresa = strEmpresa;
	}

	@Override
	public String toString() {
		return super.toString() + " Autonomo [strEmpresa=" + strEmpresa + "]";
	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = super.hashCode();
		result = prime * result + ((strEmpresa == null) ? 0 : strEmpresa.hashCode());
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
		Autonomo other = (Autonomo) obj;
		if (strEmpresa == null) {
			if (other.strEmpresa != null)
				return false;
		} else if (!strEmpresa.equals(other.strEmpresa))
			return false;
		return true;
	}

}
