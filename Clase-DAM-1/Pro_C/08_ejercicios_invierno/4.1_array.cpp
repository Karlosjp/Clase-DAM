
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]){
    /*
    Crea array numero[10];
    Haz hasta 10 
        guarda en numero[] los numeros del 1 al 10
    */

    int elemento[10];

    for(int c = 0; c < 10; c++){
        elemento[c] = c+1;
	printf("Comprobación: %i\n", elemento[c]);
    }

    return EXIT_SUCCESS;

}
