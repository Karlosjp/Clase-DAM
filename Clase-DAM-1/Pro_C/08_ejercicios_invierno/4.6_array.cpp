
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    char *lista[] = {
        "Hola",
        "Esto",
        "Es",
        "Una",
        "Lista",
        "De",
        "Palabras",
	NULL
    };
    
    for (int n=0; lista[n]!=NULL; n++)
        printf("%s\n", lista[n]);

    return EXIT_SUCCESS;

}
