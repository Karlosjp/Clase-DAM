#include <stdio.h>
#include <stdlib.h>

int main() {

	char letras[] = "0123456789ABCDEF";
	int numero;

	printf(" numero: ");
	scanf(" %i", &numero);

	printf(" %c\n", letras[numero % 16]);

	return EXIT_SUCCESS;
}

