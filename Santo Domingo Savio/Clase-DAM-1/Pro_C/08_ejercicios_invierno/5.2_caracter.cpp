
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    char letra;
   // int cambio;

    printf("Escribe una caracter : ");
    scanf(" %c", &letra);
    
    if (letra >= 120 )
        printf("En cifrado cesar es : %c\n", letra - 23);
    else 
        printf("En cifrado cesar es : %c\n", letra + 3);

    return EXIT_SUCCESS;

}
