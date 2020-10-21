
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    /*
    crea caja numero
    mientras numero sea menor o igual que 100
    enseña numero
    incrementa numero 
    */

    int numero = 0;

    while(numero <= 100){
        printf("%i \n", numero);
        numero ++;
    }  

    return EXIT_SUCCESS;

}
