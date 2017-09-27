
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define n 0x50 

int main(int argc, char *argv[]){

    char buffer[n];
    char *palabra;

    printf("Escribe un nombre :");
    fgets(buffer, n, stdin);
     
    palabra = (char *) malloc (strlen(buffer)+1);
    strcpy(palabra, buffer);
    
    printf(" %s", palabra);

    free (palabra);

    return EXIT_SUCCESS;

}
