
import java.util.Objects;
import java.util.Scanner;

/**
 * Ejercicio 13 para el control de carreras
 * @author elkin
 * @version 1.0
 */
public class Ejercicio13 {

	public static void main(String[] args) {
		final int PARTICIPANTES=10; //Número de participantes
		final double MAXIMOTIEMPO = 999;//maximo tiempo tardado en una carrera
		Scanner scnLeer=new Scanner(System.in);
		Ej13Participante [] ArrCorredores  = new Ej13Participante[PARTICIPANTES];
		Ej13Participante objAuxCorredor = new Ej13Participante();
		int intOpcion;
		int intAux, intAux2; //guardo valores auxiliares como el dorsal
		double rlnAnterior, rlnActual; //tiempo máximo de la anterior carrera
		int intPosicion; //posición del corredor con el que estamos
		
		do {
			do {
				System.out.println("******************************************\n" +
						 		   "* Seleccione una opción:\n" +
								   "*\t1.- Inscribir un participante.\r\n" +
								   "*\t2.- Mostrar listado de datos.\r\n" +
								   "*\t3.- Mostrar listado por marcas.\r\n" +
								   "*\t4.- Finalizar el programa\n" +
								   "******************************************");
				intOpcion = scnLeer.nextInt();
			}while(intOpcion<1 || intOpcion>4);
			
			switch (intOpcion) {
				case 1: for(intPosicion=0; intPosicion<ArrCorredores.length && !Objects.isNull(ArrCorredores[intPosicion]);intPosicion++);
						if(intPosicion<ArrCorredores.length) {
							System.out.println("Dame el nombre del participante");
							objAuxCorredor.setStrNombre(scnLeer.next());
							System.out.println("Dame la mejor marca del 2020 del participante " + objAuxCorredor.getStrNombre());
							objAuxCorredor.setRlnMarca2020(scnLeer.nextDouble());
							System.out.println("Dame la mejor marca del 2019 del participante " + objAuxCorredor.getStrNombre());
							objAuxCorredor.setRlnMarca2019(scnLeer.nextDouble());
							System.out.println("Dame la mejor marca del 2018 del participante " + objAuxCorredor.getStrNombre());
							objAuxCorredor.setRlnMarca2018(scnLeer.nextDouble());
							intAux=0;
							for(int intCont=0; intCont<ArrCorredores.length && !Objects.isNull(ArrCorredores[intCont]);intCont++)
								if(intAux<ArrCorredores[intCont].getIntDorsal())
									intAux=ArrCorredores[intCont].getIntDorsal();
							objAuxCorredor.setIntDorsal(++intAux);
							ArrCorredores[intPosicion] = new Ej13Participante(objAuxCorredor);
							System.out.println("El dorsal asignado es " + intAux);
						}else System.out.println("No queda sitio en el array para más corredores"); 
						break;
				case 2: for(intPosicion=0; intPosicion<ArrCorredores.length && !Objects.isNull(ArrCorredores[intPosicion]);intPosicion++)
							System.out.println(ArrCorredores[intPosicion]);
						break;
				case 3:	//voy a ver cuantos elementos tengo en el array
						for(intAux=0; intAux<ArrCorredores.length && !Objects.isNull(ArrCorredores[intAux]);intAux++);
						if(intAux==0)
							System.out.println("No hay nadie apuntado...");
						else {
							System.out.println("Imprimiendo mejores marcas 2020 " + intAux);
							rlnAnterior=MAXIMOTIEMPO;
							intAux2=intAux;
							while(intAux2>0){//saca todos los elementos
								rlnActual=0;
								for(int intCont=0; intCont<intAux;intCont++)
									//si tengo menos tiempo que el anterior impreso, pero más que el actual lo cambio
									if(ArrCorredores[intCont].getRlnMarca2020()<rlnAnterior && 
									   rlnActual<ArrCorredores[intCont].getRlnMarca2020()) {
										rlnActual=ArrCorredores[intCont].getRlnMarca2020();
									}
								rlnAnterior=rlnActual;//me guardo para la siguiente cuales he impreso
								for(int intCont=0; intCont<intAux && intAux2>0;intCont++)	
									if(rlnActual==ArrCorredores[intCont].getRlnMarca2020()) {
										System.out.println(ArrCorredores[intCont]);
										intAux2--;
									}
							}
						}

			}
			System.out.println(intOpcion);
		}while(intOpcion!=4);
		scnLeer.close();
	}
}