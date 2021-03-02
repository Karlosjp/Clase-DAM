package interfaz1;

public class Persona {
	private String strNombre, strDireccion, strFecha_Nacimiento, srtSexo;

	public Persona(String strNombre, String strDireccion, String strFecha_Nacimiento, String srtSexo) {
		super();
		this.strNombre = strNombre;
		this.strDireccion = strDireccion;
		this.strFecha_Nacimiento = strFecha_Nacimiento;
		this.srtSexo = srtSexo;
	}

	public Persona() {
		this.strNombre = null;
		this.strDireccion = null;
		this.strFecha_Nacimiento = null;
		this.srtSexo = null;
	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = 1;
		result = prime * result + ((srtSexo == null) ? 0 : srtSexo.hashCode());
		result = prime * result + ((strDireccion == null) ? 0 : strDireccion.hashCode());
		result = prime * result + ((strFecha_Nacimiento == null) ? 0 : strFecha_Nacimiento.hashCode());
		result = prime * result + ((strNombre == null) ? 0 : strNombre.hashCode());
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
		if (srtSexo == null) {
			if (other.srtSexo != null)
				return false;
		} else if (!srtSexo.equals(other.srtSexo))
			return false;
		if (strDireccion == null) {
			if (other.strDireccion != null)
				return false;
		} else if (!strDireccion.equals(other.strDireccion))
			return false;
		if (strFecha_Nacimiento == null) {
			if (other.strFecha_Nacimiento != null)
				return false;
		} else if (!strFecha_Nacimiento.equals(other.strFecha_Nacimiento))
			return false;
		if (strNombre == null) {
			if (other.strNombre != null)
				return false;
		} else if (!strNombre.equals(other.strNombre))
			return false;
		return true;
	}

	@Override
	public String toString() {
		return "Persona [strNombre=" + strNombre + ", strDireccion=" + strDireccion + ", strFecha_Nacimiento="
				+ strFecha_Nacimiento + ", srtSexo=" + srtSexo + "]";
	}
	
	public void imprimir() {
	System.out.println(this.toString());
	}
	}

