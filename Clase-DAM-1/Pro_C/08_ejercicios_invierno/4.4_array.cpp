
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]){
    
    /*
    Rellena una lista con los 20 primeros numeros de la sucesion de fibonacci.
    Crea p_numero = 1
    Crea s_numero = 1
    Crea suma
    Crea fibona
    haz hasta 20
        almacena p_numero + s_numero en suma
    */
    int p_numero = 0, s_numero = 1, suma, fibona[20];
    
    for(int c=0; c<20; c++){
        suma = p_numero + s_numero;
	fibona[c] = suma;
	printf("Comprobación: %i\n", fibona[c]);
	p_numero = s_numero;
	s_numero = suma;
    } 
    return EXIT_SUCCESS;

}
