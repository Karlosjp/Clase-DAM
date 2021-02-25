package tema5.ejercicio1;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;

public class Persona {

	protected String strNombre, strSexo, strDireccion;
	protected Date objFechaNacimiento;

	public Persona(String strNombre, String strSexo, String strDireccion, Date objFechaNacimiento) {
		this.strNombre = strNombre;
		this.strSexo = strSexo;
		this.strDireccion = strDireccion;
		this.objFechaNacimiento = objFechaNacimiento;
	}

	public void imprimir() {
		System.out.println("Nombre: " + strNombre);
		System.out.println("Nombre: " + strSexo);
		System.out.println("Nombre: " + strDireccion);
		DateFormat dateFormat = new SimpleDateFormat("yyyy-mm-dd");
		System.out.println("Nombre: " + dateFormat.format(objFechaNacimiento));
	}
	
	@Override
	public String toString() {
		return "Persona = [ Nombre: " + strNombre + ", Sexo:" + strSexo + ", Direccion: " + strDireccion
				+ ", Fecha de Nacimiento: " + objFechaNacimiento + "]";
	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = 1;
		result = prime * result + ((objFechaNacimiento == null) ? 0 : objFechaNacimiento.hashCode());
		result = prime * result + ((strDireccion == null) ? 0 : strDireccion.hashCode());
		result = prime * result + ((strNombre == null) ? 0 : strNombre.hashCode());
		result = prime * result + ((strSexo == null) ? 0 : strSexo.hashCode());
		return result;
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		Persona other = (Persona) obj;
		if (objFechaNacimiento == null) {
			if (other.objFechaNacimiento != null)
				return false;
		} else if (!objFechaNacimiento.equals(other.objFechaNacimiento))
			return false;
		if (strDireccion == null) {
			if (other.strDireccion != null)
				return false;
		} else if (!strDireccion.equals(other.strDireccion))
			return false;
		if (strNombre == null) {
			if (other.strNombre != null)
				return false;
		} else if (!strNombre.equals(other.strNombre))
			return false;
		if (strSexo == null) {
			if (other.strSexo != null)
				return false;
		} else if (!strSexo.equals(other.strSexo))
			return false;
		return true;
	}

}
