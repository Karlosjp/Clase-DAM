
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    /*
    Crea media
    Crea numero
    Haz 10 veces
        Pide un numero y guardalo en media
    media = media /10
    escribe media 
    */

    int media = 0, numero;

    for (int c=1; c<=10; c++){
        printf("Escribe un numero : ");
        scanf(" %i", &numero);
        media += numero;
    }
    
    media = media / 10;
    
    printf("La media es : %i\n", media);

    return EXIT_SUCCESS;

}
