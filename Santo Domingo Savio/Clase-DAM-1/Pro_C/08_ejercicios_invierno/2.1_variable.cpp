
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    /*
    Pide un numero y guardalo en numero
    Crea divisores
    Crea divisor = numero -1
    Mientras divisor sea > 0 haz
        si numero % divisor = 0
            incrementa divisores  
        divisor --
    si divisores > 0
        Imprime el numero tiene divisores 
    si no
        Imprime el numero no tiene divisores
    */
  
    int numero, divisor, divisores = 0;
    
    printf("Escribe un numero : \n");
    scanf(" %i", &numero);
    
    divisor = numero -1;
    while (divisor > 1){
        if (numero % divisor == 0)
            divisores ++;
        divisor --;
    }
    if (divisores > 0) 
        printf("El numero %i tiene %i divisores\n", numero, divisores);
    else
        printf("El numero %i no tiene divisores\n", numero);

    return EXIT_SUCCESS;

}
