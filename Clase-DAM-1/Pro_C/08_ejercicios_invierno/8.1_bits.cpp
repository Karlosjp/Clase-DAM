
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(int argc, char *argv[]){
    // Convierte cualquier numero expresado en decimal a cualquier base menor a 10

    int numero, tm = 0, base;
    int *inverso; 
    
    printf("Escribe un numero a convertir : ");
    scanf(" %i", &numero);
 
    printf("Escribe la base (-10) a la que quieres pasarlo : ");
    scanf(" %i", &base);

    if(base >= 10){
        printf("Base no aceptada\n");
        return EXIT_FAILURE;
    }
    
    for(int n=0; numero>0; n++){
       	inverso[n] = numero % base;
	//printf("%i", inverso[n]);
	numero /= base;
	tm ++;
    }
       
    printf("\n");
    
    int n = tm-1; 
    
    do{
        printf("%i",inverso[n]);
	n--;
    }while(n>=0);

    printf("\n");

    return EXIT_SUCCESS;

}
