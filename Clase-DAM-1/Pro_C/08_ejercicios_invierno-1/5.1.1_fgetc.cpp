
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    char letra1, letra2;
    printf("escribe letra 1 : ");
    scanf(" %c", &letra1);

    printf("escribe letra 2 : ");
    scanf(" %c", &letra2);

    printf("%c - %c\n", letra1, letra2);
    return EXIT_SUCCESS;

}
