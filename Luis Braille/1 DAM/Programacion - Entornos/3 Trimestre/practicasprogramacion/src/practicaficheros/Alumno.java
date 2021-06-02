package practicaficheros;

import java.util.ArrayList;
import java.util.List;

public class Alumno {
	private String strCodExpediente, strNombre, strApellidos, strCiclo;
	private List<Asignatura> alListaAsignaturas;

	public Alumno(String strCodExpediente, String strNombre, String strApellidos, String strCiclo,
			List<Asignatura> liAsignaturas) {
		this.strCodExpediente = strCodExpediente;
		this.strNombre = strNombre;
		this.strApellidos = strApellidos;
		this.strCiclo = strCiclo;
		this.alListaAsignaturas = liAsignaturas;
	}

	public String getStrCodExpediente() {
		return strCodExpediente;
	}

	public void setStrCodExpediente(String strCodExpediente) {
		this.strCodExpediente = strCodExpediente;
	}

	public String getStrNombre() {
		return strNombre;
	}

	public void setStrNombre(String strNombre) {
		this.strNombre = strNombre;
	}

	public String getStrApellidos() {
		return strApellidos;
	}

	public void setStrApellidos(String strApellidos) {
		this.strApellidos = strApellidos;
	}

	public String getStrCiclo() {
		return strCiclo;
	}

	public void setStrCiclo(String strCiclo) {
		this.strCiclo = strCiclo;
	}

	public List<Asignatura> getAlListaAsignaturas() {
		return alListaAsignaturas;
	}

	public void setAlListaAsignaturas(List<Asignatura> alListaAsignaturas) {
		this.alListaAsignaturas = alListaAsignaturas;
	}

	@Override
	public String toString() {
		return "CodExpediente:" + strCodExpediente + "/Nombre:" + strNombre + "/Apellidos:"
				+ strApellidos + "/Ciclo:" + strCiclo + "/ListaAsignaturas:" + alListaAsignaturas;
	}

}
