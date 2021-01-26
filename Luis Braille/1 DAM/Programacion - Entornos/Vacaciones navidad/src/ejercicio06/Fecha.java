package ejercicio06;

public class Fecha {
	private int intDia, intMes, intAnho;

	public Fecha() {
		super();
		this.intDia = 1;
		this.intMes = 1;
		this.intAnho = 2020;
	}

	public Fecha(int intDia, int intMes, int intAnho) {
		super();
		this.intDia = intDia;
		this.intMes = intMes;
		this.intAnho = intAnho;
	}

	public int getIntDia() {
		return intDia;
	}

	public void setIntDia(int intDia) {
		this.intDia = intDia;
	}

	public int getIntMes() {
		return intMes;
	}

	public void setIntMes(int intMes) {
		this.intMes = intMes;
	}

	public int getIntAnho() {
		return intAnho;
	}

	public void setIntAnho(int intAnho) {
		this.intAnho = intAnho;
	}

	public boolean fechaCorrecta() {
		boolean booDiaCorrecto, booMesCorrecto, booAnhoCorrecto;

		booMesCorrecto = intMes >= 1 && intMes <= 12;
		booAnhoCorrecto = intAnho > 0;
		
		switch (intMes) {
		case 2: 
			if(esBisiesto())
				booDiaCorrecto = intDia >= 1 && intDia <= 29;
			else
				booDiaCorrecto = intDia >= 1 && intDia <= 28;
			break;
		case 4:
		case 6:
		case 9: 
		case 11: 
			booDiaCorrecto = intDia >= 1 && intDia <= 30;
			break;
		default:
			booDiaCorrecto = intDia >= 1 && intDia <= 31;
		}
		
		return booDiaCorrecto && booMesCorrecto && booAnhoCorrecto;
	}

	private boolean esBisiesto() {
		return (intAnho % 4 == 0 && intAnho % 100 != 0 || intAnho % 400 == 0);
	}

	public void diaSiguiente() {
		intDia++;

		if (!fechaCorrecta()) {
			intDia = 1;
			intMes++;

			if (!fechaCorrecta()) {
				intMes = 1;
				intAnho++;
			}
		}
	}

	@Override
	public String toString() {
		StringBuilder sb = new StringBuilder();

		if (intDia < 10)
			sb.append("0");

		sb.append(intDia);
		sb.append("-");

		if (intMes < 10)
			sb.append("0");

		sb.append(intMes);
		sb.append("-");
		sb.append(intAnho);

		return sb.toString();
	}

}
