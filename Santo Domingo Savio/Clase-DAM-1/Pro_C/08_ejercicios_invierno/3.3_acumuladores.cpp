
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]){
    /*
    Crea pos_div = 1
    Crea pos_perf
    Crea suma_div = 0
    
    Pide un numero y metelo en pos_perf
    
    Mientras pos_div sea menor que pos_perf haz
        si pos_perf % pos_div = 0
	    suma_div += pos_div
        incrementa pos_div
    
    si suma_div = pos_perf
        escribe "el numero pos_perf es perfecto"
    si no
        escribe "el numero pos_perf no es perfecto"
    */
    
    int pos_div = 1,suma_div = 0, pos_perf;

    printf("Escribe un numero : ");
    scanf(" %i", &pos_perf);

    do{
        if (pos_perf % pos_div == 0)
	    suma_div += pos_div;
        pos_div ++;
    }while(pos_div < pos_perf);

    if (suma_div == pos_perf)
        printf("El numero %i es perfecto\n", pos_perf);
    else
	printf("El numero %i no es perfecto\n", pos_perf);

    return EXIT_SUCCESS;

}
