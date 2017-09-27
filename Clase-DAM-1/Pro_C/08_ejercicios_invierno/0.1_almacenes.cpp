#include <stdio.h>
#include <stdlib.h>

int main(){
	
	/* Crea variable edad
	Pregunta edad al usuario
	Guarda los datos introducidos en la variable edad*/

	int edad;

	system("clear");

	printf("¿Cual es tu edad? :\n");
	scanf(" %i", &edad);
	
	printf("%i \n", edad);

	return EXIT_SUCCESS;

}
