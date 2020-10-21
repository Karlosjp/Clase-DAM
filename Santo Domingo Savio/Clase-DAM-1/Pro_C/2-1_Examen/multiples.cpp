
#include <stdio.h>
#include <stdlib.h>

#define N 21

void intercambio(char *nombre){
    char *tam = nombre+N-2;
    char aux;

    for (; nombre<tam; nombre++, tam--){
        aux = *nombre;
        *nombre = *tam;
        *tam = aux;
    }
}

int main(int argc, char *argv[]){

    char nombre[N] = "me llamo Jose Manuel";

    intercambio(nombre);

    for(int i=0; i<N; i++)
        printf("%c", nombre[i]);

    printf("\n");

    return EXIT_SUCCESS;

}
