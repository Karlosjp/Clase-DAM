
#include <stdio.h>
#include <stdlib.h>

int main(){
   
	/* Crea variable nombre
	Pregunta nombre al usuario
	Guarda los datos introducidos en la variable nombre*/

	char nombre[10];

	system("clear");

	printf("¿Cual es tu Nombre? :\n");
	scanf(" %s", nombre);

	printf("%s \n", nombre);

	return EXIT_SUCCESS;
}
