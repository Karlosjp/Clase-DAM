package asterisco;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		int intLineas;
		String strLinea;
		Scanner scnLeer = new Scanner(System.in);
		
		do {
			System.out.println("Número de líneas de la prirámide: ");
			intLineas = scnLeer.nextInt();
		}while(intLineas<1);
		
		//bucle que pasa por las líneas
		for(int intCont=1;intCont <= intLineas; intCont++){
/*			//bucle que inserta los espacios en blanco
			System.out.print(intCont);
			for(int intCont2=intLineas-intCont;intCont2>0;intCont2--)
				System.out.print(' ');
			//bucle que imprime los *
			for(int intCont2=intCont;intCont2>0;intCont2--)
				System.out.print('*');
*/
			//imprimo todos los valores de una línea
			strLinea="";
			for(int intCont2=1;intCont2<=intLineas;intCont2++)
				if(intCont2>intLineas-intCont)
					strLinea+='*';
				else
					strLinea+=' ';
			System.out.println(strLinea);
		}
	}

}
