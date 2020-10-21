#include <stdio.h>
#include <stdlib.h>

/*#define MAGE 100
#define AMAR 010
#define AZUL 001
#define ROJO 110
#define MORA 101
#define VERD 011
#define NEGR 111
#define BLAN 000*/



int main(){
    //Crear variable color
    //Magenta | amarillo | azul
    //  0     |    0	 |   0
    //Preguntar si ve color magenta
    //Añadir respuesta en color
    //Preguntar si ve amarillo
    //Añadir respuesta en color
    //Preguntar si ve azul
    //Añadir respuesta en color
    //Si ve 100
    //Escribir ve magenta
    //Si ve 010
    //Escribe ve amarillo
    //Si ve 001
    //Escribe ve azul
    //Si ve 110
    //Escribe ve rojo
    //Si ve 101
    //Escribe ve morado
    //Si ve 011
    //Escribe ve verde
    //Si ve 111
    //Escribe ve blanco
    //Si ve 000
    //Escribe ve negro
	/*char opcion;
	int color=000;

	system("clear");

	printf("\n");
	printf("¿Ves magenta? s/n\n");
	scanf(" %s", &opcion);
	if (opcion == 's')
		color = color + 100;
	else
		color = color + 0;
	printf("¿Ves Amarillo? s/n\n");
	scanf(" %s", &opcion);
	if (opcion == 's')
		color = color + 10;
	else
		color = color + 0;
	printf("¿Ves Azul? s/n\n");
	scanf(" %s", &opcion);
	if (opcion == 's')
		color = color + 1;
	else
		color = color + 0;

	switch(color){
		case MAGE: printf("Ves el color Magenta\n");
			break;
		case AMAR: printf("Ves el color Amarillo\n");
			break;
		case AZUL: printf("Ves el color Azul\n");
			break;
		case ROJO: printf("Ves el color Rojo\n");
			break;
		case MORA: printf("Ves el color Morado\n");
			break;
		case VERD: printf("Ves el color Verde\n");
			break;
		case NEGR: printf("Ves el color Negro\n");
			break;
		case BLAN: printf("Ves el color Blanco\n");
			break;
	}*/
	int rojo, amarillo, azul;
	// Entrada de datos
	printf("Rojo (0/1): ");
	scanf(" %i", &rojo);

	printf("Amarillo (0/1): ");
	scanf(" %i", &amarillo);

	printf("Azul (0/1): ");
	scanf(" %i", &azul);
	
	/*Procesado */

	if (rojo)
		if (amarillo)
			if (azul)
				printf("Blanco");
			else
				printf("Naranja");
		else
			if (azul)
				printf("Morado");
			else
				printf("Rojo");
	else
		if (rojo)
			if (rojo)
				printf("Verde");
			else
				printf("Amarillo");
		else
			if (rojo)
				printf("Azul");
			else
				printf("Negro");


	printf("\n");

	return EXIT_SUCCESS;
}
