package ejerciciosFecha;

public class Fecha {
	int dia;
	int mes;
	int anio;

	public Fecha() {
		dia = 12;
		mes = 9;
		anio = 2016;
	}

	public int getDia() {
		return dia;
	}

	public void setDia(int dia) {
		this.dia = dia;
	}

	public int getMes() {
		return mes;
	}

	public void setMes(int mes) {
		this.mes = mes;
	}

	public int getAnio() {
		return anio;
	}

	public void setAnio(int anio) {
		this.anio = anio;
	}

	public String escribirCorto() {
		String fecha;

		if (correcta())
			fecha = dia + "/" + mes + "/" + anio;
		else
			fecha = "Error en la fecha " + dia + "/" + mes + "/" + anio;

		return fecha;
	}

	public String escribirLargo() {
		String fecha;

		if (correcta())
			fecha = "El dia: " + dia + " del mes: " + mes + " del año: " + anio;
		else
			fecha = "Error en la fecha " + dia + "/" + mes + "/" + anio;

		return fecha;
	}

	// Metodos privados
	private boolean cDia() {
		boolean cdia = false;

		if (dia < 0 && dia > 31)
			cdia = true;

		return cdia;
	}

	private boolean cMes() {
		boolean cmes = false;

		if (mes < 0 && mes > 12)
			cmes = true;

		return cmes;
	}

	private boolean correcta() {
		boolean correcto = false;

		if (cMes() && cDia())
			correcto = true;

		return correcto;
	}
}
