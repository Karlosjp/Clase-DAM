#include <stdio.h>
#include <stdlib.h>

int dividir(const int numero, int divisor){
    divisor --;

    printf("Numero = %i, Divisor = %i => Resto %i\n",
            numero, divisor, numero%divisor);

    if(numero % divisor == 0){
        return 0;
    }

    if(divisor <= 2){
        return 1;
    }

    return dividir(numero,divisor);
}

int main(int argc, char *argv[]){
    int numero;

    printf("Escribe un numero: ");
    scanf(" %i", &numero);

    if(!dividir(numero,numero)){
        printf("El numero tiene divisor\n");
    }else{
        printf("El numero  no tiene divisor\n");
    }
}

