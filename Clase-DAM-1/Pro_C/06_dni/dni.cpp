#include <stdio.h>
#include <stdlib.h>
	/*Crea caja letra
	Crea caja asigna
	Crea caja DNI
	Crea caja numero
	Pide un numero DNI con letra y guardalo en DNI
	Longitud de DNI -1 = numero
	Longitud de DNI -8(por la izquierda) = letra
	Obten  numero % 23 y guardalo en numero
	Si numero es igual a:
		0 => asigna es igual a T	1 => asigna es igual a R
		2 => asigna es igual a W	3 => asigna es igual a A
		4 => asigna es igual a G	5 => asigna es igual a M
		6 => asigna es igual a Y	7 => asigna es igual a F
		8 => asigna es igual a P	9 => asigna es igual a D
		10 => asigna es igual a X	11 => asigna es igual a B
		12 => asigna es igual a N	13 => asigna es igual a J
		14 => asigna es igual a Z	15 => asigna es igual a S
		16 => asigna es igual a Q	17 => asigna es igual a V
		18 => asigna es igual a H	19 => asigna es igual a L
		20 => asigna es igual a C	21 => asigna es igual a K
		22 => asigna es igual a E
	Si asigna == letra escribe:
		El numero DNI es correcto
	Si no
		El numero DNI es incorrecto*/
int main(){

	char letras[] = "TRWAGMYPFDXBNJZSQVHLCKE";
	int dni; 
	
	printf("dni: ");
	scanf(" %i", &dni);

	printf("%c\n", letras[dni % 23]);


	return EXIT_SUCCESS;
}

