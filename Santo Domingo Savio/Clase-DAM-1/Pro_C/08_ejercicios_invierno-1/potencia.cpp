
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(int argc, char *argv[]){

    int exponente = 0;
    int potencia = 0;
    int resultado;
    printf("exponente");
    scanf(" %i", &exponente);
    printf("potencia");
    scanf(" %i", &potencia);
    resultado =(int *) pow(exponente,potencia);
    printf(" %i\n", resultado);
    return EXIT_SUCCESS;

}
