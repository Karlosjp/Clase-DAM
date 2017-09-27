
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(int argc, char *argv[]){

    //Busca el final de una cadena de caracteres e imprimela de atras hacia delante
    int tam;
    char cadena[] = "wqersdfergfdbdg";

    tam = (sizeof(cadena) / sizeof(char)) - 2;
 
    while (tam>0){
        printf(" %c\n", cadena[tam]);
	tam--;
    }

    return EXIT_SUCCESS;

}
