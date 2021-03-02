package interfaz1;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Persona[] ArrPersona = new Persona[5];
		ArrPersona[0]= new Persona();
		ArrPersona[1]= new Estudiante();
		ArrPersona[2]= new Trabajador();
		ArrPersona[3]= new Trabajador_Autonomo();
		ArrPersona[4]= new Trabajador_paro();
		
		
		
		ArrPersona[0].imprimir();
	}

}
