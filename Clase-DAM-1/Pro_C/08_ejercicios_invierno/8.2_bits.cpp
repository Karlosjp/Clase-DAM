
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    //Cambia un numero a hexadecimal

    int numero, tm = 0;
    char *h_numero;
    char acumulador[] = "0123456789ABCDEF";


    printf("Escribe un numero : ");
    scanf(" %i", &numero);

    for (int n=0; numero>0; n++){
        h_numero[n], acumulador[numero % 16];
	tm ++;
        numero /= 16;
    }

    int max = tm -1;
    do{
        printf("%c", h_numero[max]);
	max--;
    }while(tm>0);

    printf("\n");

    return EXIT_SUCCESS;

}
