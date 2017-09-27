
#include <stdio.h>
#include <stdlib.h>

int main(){
	FILE *tubo; // stream

	tubo = fopen ("iberos.txt", "w");

	printf("Hola\n");

	fprintf(stdout, "Hola\n");
	fprintf(tubo "Hola \n");

	fclose(tubo);

    return EXIT_SUCCESS;

}
