#include <stdio.h>
#include <stdlib.h>

int main(){
	
	/* Crea variable letra
	Pregunta letra al usuario
	Guarda los datos introducidos en la variable letra*/

	char letra;

	system("clear");

	printf("¿Cual es tu letra preferida? :\n");
	scanf(" %c", &letra);

	printf("%c \n", letra);

	return EXIT_SUCCESS;
}
